namespace TVSI.XTRADE.BO.API.Models.Dtos
{
    public class FunctionsDto
    {
        public string PkFunctionCode { get; set; }
        public string FunctionName { get; set; }
        public List<ActionsDto> Actions { get; set; }
    }
}