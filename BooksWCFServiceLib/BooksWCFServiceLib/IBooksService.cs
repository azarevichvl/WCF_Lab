using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace BooksWCFServiceLib
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IBooksService
    {
        [WebInvoke(Method = "GET")]
        [OperationContract]
        string getInfo(string name);

        [WebInvoke(Method = "GET")]
        [OperationContract]
        List<string> getBooksByYear(int year);

        [WebInvoke(Method = "GET")]
        [OperationContract]
        List<string> getAvailableBooks();

        // TODO: Добавьте здесь операции служб
    }

    // Используйте контракт данных, как показано на следующем примере, чтобы добавить сложные типы к сервисным операциям.
    // В проект можно добавлять XSD-файлы. После построения проекта вы можете напрямую использовать в нем определенные типы данных с пространством имен "BooksWCFServiceLib.ContractType".

}
