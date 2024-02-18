namespace XGame.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public string Message { get; set; }

        public ResponseBase()
        {
            Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO;
        }

        public static explicit operator ResponseBase(Entities.Jogo entidade)
        {
            return new ResponseBase()
            {
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
