namespace Transact;

public class PageModel(int page, bool isSelected = false)
{
    public int PageText { get; set; } = page;
    public bool IsSelected { get; set; } = isSelected;
}