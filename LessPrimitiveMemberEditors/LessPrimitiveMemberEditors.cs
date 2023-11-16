using HarmonyLib;
using ResoniteModLoader;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;
using FrooxEngine;
using Elements.Core;

namespace LessPrimitiveMemberEditors;

public class LessPrimitiveMemberEditors : ResoniteMod
{
    public override string Name => "LessPrimitiveMemberEditors";
    public override string Author => "art0007i";
    public override string Version => "1.0.0";
    public override string Link => "https://github.com/art0007i/LessPrimitiveMemberEditors/";
    public override void OnEngineInit()
    {
        Harmony harmony = new Harmony("me.art0007i.LessPrimitiveMemberEditors");
        harmony.PatchAll();

    }
    [HarmonyPatch(typeof(PrimitiveTryParsers), "GetParser", new Type[] { typeof(Type) })]
    class ParserExtensions
    {
        public static Exception Finalizer(Exception __exception, ref PrimitiveTryParsers.TryParser __result, Type type)
        {
            if (__exception != null)
            {
                MethodInfo pars;
                if (type.IsEnum) pars = AccessTools.FirstMethod(typeof(Enum), (mi) => mi.Name == "TryParse" && mi.GetParameters().Length == 2).MakeGenericMethod(type);
                else pars = AccessTools.FirstMethod(typeof(RobustParser), (mi) => mi.GetParameters().Last().ParameterType == type.MakeByRefType());

                if (pars == null) return __exception;
                __result = delegate (string str, out object obj)
                {
                    object[] parsed = new object[] { str, null };
                    if ((bool)pars.Invoke(null, parsed))
                    {
                        obj = parsed[1];
                        return true;
                    }
                    obj = null;
                    return false;
                };
            }
            return null;
        }
    }
}
