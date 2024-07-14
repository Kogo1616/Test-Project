namespace TestProject.Services;

public class CommonService : ICommonService
{
    private readonly IFinancialStatementsService _financialStatementsService;

    public CommonService(IFinancialStatementsService financialStatementsService)
    {
        _financialStatementsService = financialStatementsService;
    }

    public void CommonMethod()
    {
        // Implementation here
    }
}