using UnityEngine;

public class PowerUpHight : PowerUpBase
{
    [Header("PowerUp Hight")]
    public float amountHight = 2;
    public float animationDuration = .1f;
    public DG.Tweening.Ease ease = DG.Tweening.Ease.OutBack;

    protected override void StartPowerUp()
    {
        base.StartPowerUp();
        PlayerController.Instance.ChangeHeight(amountHight, duration, animationDuration, ease);
        PlayerController.Instance.SetPowerUpText("Jump");

    }

    protected override void EndPowerUp()
    {
        base.EndPowerUp();
        PlayerController.Instance.ResetHight(animationDuration);
        PlayerController.Instance.SetPowerUpText("");

    }

}
