//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
namespace BB3D
{
		public class AnimationUtils
		{
				public AnimationUtils ()
				{
				}

				public static void PlayAnimation(Animation animation,string animationName){
					animation [animationName].speed = 1.0F;
					animation.Play(animationName);
				}

				public static void PlayAnimationReversed(Animation animation,string animationName){
					animation [animationName].speed = -1.0F;
					animation [animationName].time = animation [animationName].length;
					animation.Play(animationName);
				}
		}
}
