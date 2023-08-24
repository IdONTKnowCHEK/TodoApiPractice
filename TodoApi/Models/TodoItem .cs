// 建立「模型」代表應用程式所管理資料的一組類別
// 包含屬性 Name, IsComplet

namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public string? Secret { get; set; }
}