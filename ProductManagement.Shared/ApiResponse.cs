using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Shared;

/// <summary>
/// Tipo de dato para envolver y unificar las respuestas de los controladores y repositorios.
/// </summary>
public class ApiResponse<T> : ControllerBase
{
    public bool Success { get; set; }
    public T? Data { get; set; }
    public string? Message { get; set; }
    /// <summary>
    /// Marcar como true si el backend lanzó una excepción.
    /// </summary>
    public bool IsException { get; set; } = false;
    public bool DataIsNull => Data == null;

    public IActionResult ToActionResult()
    {
        if (Success) return Ok(new { Success, Data, Message, IsException });

        if (IsException) return new ObjectResult(new { Success, Data, Message, IsException }) { StatusCode = 500 };

        return BadRequest(new { Success, Data, Message, IsException });
    }

}
