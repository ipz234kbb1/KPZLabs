namespace Composite;

public static class TableBuilder
{
    public static void AddTableRow(LightElementNode tbody, string id, string name, string position, string department)
    {
        var tr = new LightElementNode("tr", "table-row", false);
            
        var tdId = new LightElementNode("td", "table-cell", false);
        tdId.AddChild(new LightTextNode(id));
        tr.AddChild(tdId);
            
        var tdName = new LightElementNode("td", "table-cell", false);
        tdName.AddChild(new LightTextNode(name));
        tr.AddChild(tdName);
            
        var tdPosition = new LightElementNode("td", "table-cell", false);
        tdPosition.AddChild(new LightTextNode(position));
        tr.AddChild(tdPosition);
            
        var tdDepartment = new LightElementNode("td", "table-cell", false);
        tdDepartment.AddChild(new LightTextNode(department));
        tr.AddChild(tdDepartment);
            
        tbody.AddChild(tr);
    }
}