
using EnterpriseStore.Service.Notificacoes;
using System.Collections.Generic;

namespace EnterpriseStore.Service.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}