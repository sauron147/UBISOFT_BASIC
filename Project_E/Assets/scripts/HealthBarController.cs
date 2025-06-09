using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Image hpFill; // HP_Fill �̹���

    private float hp = 1.0f; // ü�� (0 ~ 1.0f) 100%

    public void TakeDamage()
    {
        hp -= 0.1f;
        hp = Mathf.Clamp01(hp); // 0���� �۾����� �ʰ�
        UpdateHPBar();
    }

    public void Heal()
    {
        hp += 0.1f;
        hp = Mathf.Clamp01(hp); // 1���� Ŀ���� �ʰ�
        UpdateHPBar();
    }

    private void UpdateHPBar()
    {
        if (hpFill != null)
        {
            hpFill.rectTransform.localScale = new Vector3(hp, 1, 1);
        }
        else
        {
            Debug.LogError("hpFill is NULL! ���� Ȯ�� �ʿ�!");
        }
    }
}
