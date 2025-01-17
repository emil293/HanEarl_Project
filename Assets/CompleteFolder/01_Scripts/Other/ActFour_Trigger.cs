using System.Collections;
using UnityEngine;

public class ActFour_Trigger : MonoBehaviour
{
    [SerializeField] private KFadeManager _fadeManager;
    private void Awake()
    {
        _fadeManager = FindObjectOfType<KFadeManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        if (TryGetComponent(out KInteractiveObject i))
        {
            i.Interactive();
        }
    }

    public void BadEndingAStartRoutine()
    {
        StartCoroutine(BadEndingAStart());
    }
    private IEnumerator BadEndingAStart()
    {
        _fadeManager.FadeOut_ImageSetActiveTrueRoutine(1);
        yield return new WaitForSeconds(3);
        _fadeManager.FadeInRoutine(2);
        G_DifurcationManager.Instance.CallEnding("BadEndingA");
        KTimeLineManager.Instance.StartTimeLine("10");
        gameObject.SetActive(false);
    }
}
