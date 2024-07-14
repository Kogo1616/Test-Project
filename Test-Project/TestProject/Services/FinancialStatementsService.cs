namespace TestProject.Services;

public class FinancialStatementsService : IFinancialStatementsService
{
    private readonly ICommonService _commonService;

    public FinancialStatementsService(ICommonService commonService)
    {
        _commonService = commonService;
    }

    public void FinancialMethod()
    {
        // Implementation here
    }
}