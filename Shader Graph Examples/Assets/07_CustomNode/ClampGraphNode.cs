//using UnityEngine;
//using UnityEditor.ShaderGraph;
//using System.Reflection;

//[Title("Custom", "Clamp Node")]
//public class ClampGraphNode : CodeFunctionNode
//{
//    public ClampGraphNode()
//    {
//        name = "Clamp Node";
//    }

//    protected override MethodInfo GetFunctionToConvert()
//    {
//        return GetType().GetMethod("ClampFunction", BindingFlags.Static | BindingFlags.NonPublic);
//    }

//    static string ClampFunction([Slot(0, Binding.None)] DynamicDimensionVector Value, [Slot(1, Binding.None)] DynamicDimensionVector Min, [Slot(2, Binding.None)] DynamicDimensionVector Max, [Slot(3, Binding.None)]out DynamicDimensionVector Out)
//    {
//        return @"
//{
//            Out = Value;
//            if(Value < Min)
//            {
//                Out = Min;
//            }
            
//            if(Value > Max)
//            {
//                Out = Max;
//            }
//}
//        ";
//    }
//}
