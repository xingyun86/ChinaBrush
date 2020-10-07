using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace ChinaBrush
{
    public class ChineseBrushCanvas : InkCanvas
    {
        public ChineseBrushCanvas()
        {
            //当然要换上我们特地搞出来的ChinesebrushRenderer
            this.DynamicRenderer = new ChineseBrushRenderer();
        }


        protected override void OnStrokeCollected(InkCanvasStrokeCollectedEventArgs e)
        {
            //感兴趣的童鞋，注释这一句看看？
            this.Strokes.Remove(e.Stroke);

            this.Strokes.Add(new ChineseBrushStroke(e.Stroke.StylusPoints, this.DefaultDrawingAttributes.Color));
        }
    }
}
