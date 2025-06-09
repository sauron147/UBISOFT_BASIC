using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Image hpFill; // HP_Fill 이미지

    private float hp = 1.0f; // 체력 (0 ~ 1.0f) 100%

    public void TakeDamage()
    {
        hp -= 0.1f;
        hp = Mathf.Clamp01(hp); // 0보다 작아지지 않게
        UpdateHPBar();
    }

    public void Heal()
    {
        hp += 0.1f;
        hp = Mathf.Clamp01(hp); // 1보다 커지지 않게
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
            Debug.LogError("hpFill is NULL! 연결 확인 필요!");
        }
    }
}
