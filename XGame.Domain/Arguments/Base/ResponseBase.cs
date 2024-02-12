namespace XGame.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public string Message { get; set; }

        public ResponseBase()
        {
            Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO;
        }
    }
}
