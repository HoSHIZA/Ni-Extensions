using System.Collections;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class LayoutRebuilderExtensions
    {
        /// <summary>
        /// Rebuilds the layout for the given <paramref name="obj"/>'s RectTransform component.
        /// </summary>
        /// <param name="obj">The <see cref="MonoBehaviour"/> whose layout needs to be rebuilt.</param>
        /// <param name="layoutNesting">The number of times to rebuild the layout.</param>
        public static void RebuildLayout(this MonoBehaviour obj, int layoutNesting = 1)
        {
            obj.StartCoroutine(RebuildLayout(obj.transform as RectTransform, layoutNesting));
        }
        
        /// <summary>
        /// Refreshes the given <paramref name="sizeFitter"/>, forcing it to recalculate its size constraints.
        /// </summary>
        /// <param name="sizeFitter">The <see cref="ContentSizeFitter"/> to refresh.</param>
        public static void Refresh(this ContentSizeFitter sizeFitter)
        {
            var horizontalFit = sizeFitter.horizontalFit;
            var verticalFit = sizeFitter.verticalFit;
                
            sizeFitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
            sizeFitter.verticalFit = ContentSizeFitter.FitMode.Unconstrained;
            
            sizeFitter.horizontalFit = horizontalFit;
            sizeFitter.verticalFit = verticalFit;
        }

        private static IEnumerator RebuildLayout(RectTransform rectTransform, int iterations)
        {
            for (var i = 0; i < iterations; i++)
            {
                LayoutRebuilder.ForceRebuildLayoutImmediate(rectTransform);
            }

            yield return new WaitForEndOfFrame();

            for (var i = 0; i < iterations; i++)
            {
                LayoutRebuilder.ForceRebuildLayoutImmediate(rectTransform);
            }
        }
    }
}