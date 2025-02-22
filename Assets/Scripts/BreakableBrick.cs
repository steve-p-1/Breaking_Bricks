using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour
{
    //Variables
    [SerializeField,Range(1,20)] protected int hitsToBreak;
    [SerializeField,Range(1,20)] protected int pointValue;
    protected int curHitsToBreak = 0;
    // break emitter
    [SerializeField] ParticleSystem hit_ps;

  //methods
  private void Awake()
    {
        curHitsToBreak = hitsToBreak;
    }
    public void Break(int aDamage)
    {
        curHitsToBreak -= aDamage;
        hit_ps.Play();
        BreakBrick();
    }

    protected void BreakBrick()
    {

        if (curHitsToBreak <=  0)
        {
            GameManager.Instance.AddScore(pointValue);
            Destroy(gameObject);
        }
    }

    //accessors
}
