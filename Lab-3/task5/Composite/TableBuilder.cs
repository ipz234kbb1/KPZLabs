namespace Composite;

public static class TableBuilder
{
    public static void AddTableRow(LightElementNode tbody, string id, string name, string position, string department)
    {
        var tr = new LightElementNode("tr");
            
        var tdId = new LightElementNode("td", false);
        tdId.AddChild(new LightTextNode(id));
        tr.AddChild(tdId);
            
        var tdName = new LightElementNode("td", false);
        tdName.AddChild(new LightTextNode(name));
        tr.AddChild(tdName);
            
        var tdPosition = new LightElementNode("td", false);
        tdPosition.AddChild(new LightTextNode(position));
        tr.AddChild(tdPosition);
            
        var tdDepartment = new LightElementNode("td", false);
        tdDepartment.AddChild(new LightTextNode(department));
        tr.AddChild(tdDepartment);
            
        tbody.AddChild(tr);
    }
}