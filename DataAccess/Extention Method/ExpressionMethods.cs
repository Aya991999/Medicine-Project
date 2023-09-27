using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models.DBModels;
using MyBusinessAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Extention_Method
{
    public static class ExpressionMethods
    {
        public static Expression<Func<T, object>> ToLambdaOrder<T>(string propertyName)
        {
            if(propertyName==null)
                return null;
              var parameter = Expression.Parameter(typeof(T));
            var property = Expression.Property(parameter, propertyName);
            var propAsObject = Expression.Convert(property, typeof(object));

            return Expression.Lambda<Func<T, object>>(propAsObject, parameter);
        }
        public static Expression<Func<T, bool>> ToLambdaCompare<T>(object obj)
        {
            if (obj == null)
                return null;
            var Filters = JsonConvert.DeserializeObject<Dictionary<string, string>>(obj.ToString());

            var objs = new List<T>();
            var compare = Expression.Equal(Expression.Constant(1), Expression.Constant(1));
            var parameter = Expression.Parameter(typeof(T));
            foreach (var item in Filters)
            {

                var property = Expression.Property(parameter, item.Key);

                var propAsObject = Expression.Equal(property, Expression.Constant(item.Value));
                compare = Expression.And(compare, propAsObject);



                // Func<M_Enterprise_B_Customer, bool> isTeenAger = s => propAsObject == item.Value && s.Age < 20;

            }
            return Expression.Lambda<Func<T, bool>>(compare, parameter);

        }

        public static Expression<Func<T, bool>> ToLambdaContain<T>(object obj,string Type)
        {
            if (obj == null)
                return null;
            var Filters = JsonConvert.DeserializeObject<Dictionary<string, string>>(obj.ToString());

            var objs = new List<T>();
            var compare = Expression.Equal(Expression.Constant(1), Expression.Constant(1));
            var parameter = Expression.Parameter(typeof(T));
            foreach (var item in Filters)
            {
              
                var property = Expression.Property(parameter, item.Key);
              
                MethodInfo method = item.Value.GetType().GetMethod(Type, new Type[] { typeof(string)  });
                var someValue = Expression.Constant(item.Value);
                var containsMethodExp = Expression.Call(property, method, someValue);
              
                compare = Expression.And(compare, containsMethodExp);



                // Func<M_Enterprise_B_Customer, bool> isTeenAger = s => propAsObject == item.Value && s.Age < 20;

            }
            return Expression.Lambda<Func<T, bool>>(compare, parameter);

        }

        /*
         *   var xx = JsonConvert.DeserializeObject<Dictionary<string, string>>(obj.ToString());
            var objs= new List<M_Enterprise_B_Customer>();
            var c = Expression.Equal( Expression.Constant(1), Expression.Constant(1));
            var parameter = Expression.Parameter(typeof(M_Enterprise_B_Customer));


            foreach (var item in xx)
            {
           
                var property = Expression.Property(parameter, item.Key);
                
                var propAsObject= Expression.Equal(property,Expression.Constant(item.Value));
                 c = Expression.And(c, propAsObject);

               

                // Func<M_Enterprise_B_Customer, bool> isTeenAger = s => propAsObject == item.Value && s.Age < 20;

            }
            var ex = Expression.Lambda<Func<M_Enterprise_B_Customer, bool>>(c, parameter);
*/
    }
}
