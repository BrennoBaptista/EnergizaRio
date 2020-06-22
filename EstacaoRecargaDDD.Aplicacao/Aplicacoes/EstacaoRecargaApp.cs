using EstacaoRecargaDDD.Aplicacao.Interfaces;
using EstacaoRecargaDDD.Dominio.Entidades;
using EstacaoRecargaDDD.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacaoRecargaDDD.Aplicacao.Aplicacoes
{
    public class EstacaoRecargaApp : IEstacaoRecargaApp
    {
        IEstacaoRecarga _estacaoRecargaInterface;

        public EstacaoRecargaApp(IEstacaoRecarga estacaoRecargaInterface)
        {
            _estacaoRecargaInterface = estacaoRecargaInterface;
        }

        public void Adicionar(EstacaoRecarga obj)
        {
            _estacaoRecargaInterface.Adicionar(obj);
        }

        public void Atualizar(EstacaoRecarga obj)
        {
            _estacaoRecargaInterface.Atualizar(obj);
        }

        public void Excluir(EstacaoRecarga obj)
        {
            _estacaoRecargaInterface.Excluir(obj);
        }

        public IList<EstacaoRecarga> Listar()
        {
            return _estacaoRecargaInterface.Listar();
        }

        public EstacaoRecarga RecuperarPorId(Guid id)
        {
            return _estacaoRecargaInterface.RecuperarPorId(id);
        }
    }
}
