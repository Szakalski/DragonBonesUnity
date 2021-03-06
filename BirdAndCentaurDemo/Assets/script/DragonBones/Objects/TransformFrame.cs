// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using Com.Viperstudio.Geom;
using System.Collections.Generic;

namespace DragonBones.Objects
{
	public class TransformFrame : Frame
	{
		public float TweenEasing;
		public int TweenRotate;
		public int DisplayIndex;
		public bool Visible;
		public float ZOrder;
		
		public DBTransform Global;
		public DBTransform Transform;
		public Point Pivot;
		public ColorTransform Color;
		
		
		public TransformFrame()
		{
			
			TweenEasing = 0;
			TweenRotate = 0;
			DisplayIndex = 0;
			Visible = true;
			ZOrder = float.NaN;
			
			Global = new DBTransform();
			Transform = new DBTransform();
			Pivot = new Point();
		}
		
		override public void Dispose()
		{
			base.Dispose();
			Global = null;
			Transform = null;
			//SkeletonData pivots
			Pivot = null;
			Color = null;
		}
	}
}

