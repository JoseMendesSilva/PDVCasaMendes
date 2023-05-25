using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CasaMendes
{
    //[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    [Serializable]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = true, Inherited = true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public sealed class OpcoesBase : Attribute
    {
        public bool UsarNoBancoDeDados { get; set; }
        public bool UsarParaBuscar { get; set; }
        public bool ChavePrimaria { get; set; }
        public bool AutoGenerantor { get; set; }
    }
}
