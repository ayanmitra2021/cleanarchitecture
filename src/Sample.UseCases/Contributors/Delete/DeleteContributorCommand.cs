using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Sample.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
