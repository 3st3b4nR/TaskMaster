namespace TaskMasterAPI.DTOs;

public record CreateTaskDto(string Title);

public record TaskResponseDto(int Id, string Title, bool IsCompleted);