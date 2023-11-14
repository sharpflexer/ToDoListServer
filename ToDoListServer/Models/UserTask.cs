namespace ToDoListServer.Models;

/// <summary>
/// Пользовательская задача.
/// </summary>
public class UserTask
{
    /// <summary>
    /// ID задачи.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название задачи.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание задачи.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// ID категории.
    /// </summary>
    public int CategoryID { get; set; }
}
