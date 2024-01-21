namespace DigaoDeskApp
{
    public class TSRenderer : ToolStripSystemRenderer
    {
        public TSRenderer() : base() { }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip.GetType() == typeof(ToolStrip))
            {
                // skip render border
            }
            else
            {
                // do render border
                base.OnRenderToolStripBorder(e);
            }
        }
        
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected || e.Item.Pressed)
            {
                Rectangle rectangle = new(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                e.Graphics.FillRectangle(new SolidBrush(ControlPaint.Light(Vars.Config.Theme.ToolbarBack, 5)), rectangle);
                e.Graphics.DrawRectangle(new Pen(ControlPaint.Light(Vars.Config.Theme.ToolbarBack, 10)), rectangle);
                return;
            }

            base.OnRenderButtonBackground(e);
        }

        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            OnRenderButtonBackground(e);
        }

    }
}
