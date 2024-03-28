using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Sample.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
