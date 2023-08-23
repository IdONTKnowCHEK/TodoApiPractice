// TodoContext 負責管理應用程式與資料庫之間的資料存取
// 用來連接資料庫、模型定義、資料操作等


// 由 Microsoft 提供的框架，用於在 .NET 平台上開發資料存取層。
// 使用 ORM 操作簡化 API 設計
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

// DbContext 用於定義應用程式與資料庫之間的映射關係
// 包含了資料庫中每個表格的對應實體類別（Entity Class）
// 這些實體類別代表資料庫中的資料
// 可以查詢、新增、更新和刪除資料
public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    // DbSet<TodoItem>屬性表示一個實體集合
    // 用於存取和操作名為 "TodoItems" 的資料表
    // 將資料庫中的行或文檔表示為物件，並使用物件導向的方式進行操作
    // TodoItems屬性將被映射到資料庫中的TodoItem實體集合。屬性的初始化為null!，表示它不允許為null
    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}