namespace School_Project.ClassesFolder;

public class TransparentTabControl : TabControl, ITransparentTabControl
{
    private readonly List<Panel> _pages = new();

    public void MakeTransparent()
    {
        if (TabCount == 0) throw new InvalidOperationException();
        var height = GetTabRect(0).Bottom;
        // Move controls to panels
        for (var tab = 0; tab < TabCount; ++tab)
        {
            var page = new Panel
            {
                Left = Left,
                Top = Top + height,
                Width = Width,
                Height = Height - height,
                BackColor = Color.Transparent,
                Visible = tab == SelectedIndex
            };
            for (var ix = TabPages[tab].Controls.Count - 1; ix >= 0; --ix)
                TabPages[tab].Controls[ix].Parent = page;
            _pages.Add(page);

            //Control? parent = Parent;
            Parent.Controls.Add(page);
        }

        Height = height /* + 1 */;
    }

    protected override void OnSelectedIndexChanged(EventArgs e)
    {
        base.OnSelectedIndexChanged(e);
        for (var tab = 0; tab < _pages.Count; ++tab)
            _pages[tab].Visible = tab == SelectedIndex;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            foreach (var page in _pages)
                page.Dispose();
        base.Dispose(disposing);
    }
}