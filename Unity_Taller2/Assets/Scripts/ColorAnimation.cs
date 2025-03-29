using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAnimation : MonoBehaviour
{


    private Animator animator;

    [SerializeField]
    private GameObject button;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Subscribe()
    {
        ColorManager.Instance.OnColorChanged += OnColorChanged;
        button.gameObject.SetActive(false);
    }

    public void Unsubscribe()
    {
        ColorManager.Instance.OnColorChanged -= OnColorChanged;
        button.gameObject.SetActive(true);
    }
    public void OnColorChanged(Color newColor)
    {
        if (newColor == Color.red)
        {
            animator.SetTrigger("RedTrigger");
            StartCoroutine(ResetTrigger("RedTrigger"));
        }
        else if (newColor == Color.blue)
        {
            animator.SetTrigger("BlueTrigger");
            StartCoroutine(ResetTrigger("BlueTrigger"));
        }
        else if (newColor == Color.green)
        {
            animator.SetTrigger("GreenTrigger");
            StartCoroutine(ResetTrigger("GreenTrigger"));
        }
    }

    private IEnumerator ResetTrigger(string triggerName)
    {
        yield return new WaitForSeconds(GetAnimationLength(triggerName)); // Espera la duración exacta de la animación
        animator.ResetTrigger(triggerName);
    }

    private float GetAnimationLength(string triggerName)
    {
        // Obtiene la duración de la animación activa en la capa 0
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        return stateInfo.length;
    }
}
