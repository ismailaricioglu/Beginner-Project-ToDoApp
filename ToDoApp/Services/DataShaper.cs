using Entities.Models;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DataShaper<T> : IDataShaper<T>
        where T : class
    {
        public PropertyInfo[] Properties { get; set; }
        public DataShaper()
        {
            Properties = typeof(T)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }
        public IEnumerable<ShapedEntity> ShapeData(IEnumerable<T> entities, string fieldsString)
        {
            var requeiredFields = GetRequiredProperties(fieldsString);
            return FetchData(entities, requeiredFields);
        }

        public ShapedEntity ShapeData(T entity, string fieldsString)
        {
            var requeiredProperties = GetRequiredProperties(fieldsString);
            return FetchDataForEntity(entity, requeiredProperties);
        }

        private IEnumerable<PropertyInfo> GetRequiredProperties(string fieldsString)
        {
            var requiredFields = new List<PropertyInfo>();
            if (!string.IsNullOrWhiteSpace(fieldsString))
            {
                var fields = fieldsString.Split(',',
                    StringSplitOptions.RemoveEmptyEntries);
                foreach (var field in fields)
                {
                    var property = Properties
                        .FirstOrDefault(pi => pi.Name.Equals(field.Trim(),
                        StringComparison.InvariantCultureIgnoreCase));
                    if (property is null)
                        continue;

                    requiredFields.Add(property);
                }
            }
            else
            {
                requiredFields = Properties.ToList();
            }
            return requiredFields;
        }

        private ShapedEntity FetchDataForEntity(T entity,
            IEnumerable<PropertyInfo> requiredProperties)
        {
            var shapedObject = new ShapedEntity(); // çalışma zamanında nesne üretimi yapılacak

            foreach (var property in requiredProperties)
            {
                var objectPropertyValue = property.GetValue(entity);
                shapedObject.Entity.TryAdd(property.Name, objectPropertyValue);
            }

            var objectProperty = entity.GetType().GetProperty("Id");
            shapedObject.Id = (int)objectProperty.GetValue(entity);

            return shapedObject;
        }

        private IEnumerable<ShapedEntity> FetchData(IEnumerable<T> entities,
            IEnumerable<PropertyInfo> requiredProperties)
        {
            var shapedData = new List<ShapedEntity>(); // çalışma zamanında nesneler üretimi yapılacak
            foreach (var entity in entities)
            {
                var shapedObject = FetchDataForEntity(entity, requiredProperties);
                shapedData.Add(shapedObject);
            }
            return shapedData;
        }
    }
}
;