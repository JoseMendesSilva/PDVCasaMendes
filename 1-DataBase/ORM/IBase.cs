using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CasaMendes
{
    [ComVisible(true)]
    public interface IBase
    {
        int Key { get; }

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Salvar();

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Excluir();

        [MethodImpl(MethodImplOptions.InternalCall)]
        [SecurityCritical]
        void CriarTabela();

        [MethodImpl(MethodImplOptions.InternalCall)]
        List<IBase> Todos();

        [MethodImpl(MethodImplOptions.InternalCall)]
        List<IBase> Busca();
    }
}
