
using EnterpriseStore.Domain.Notificacoes;
using System.Collections.Generic;

namespace EnterpriseStore.Domain.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}