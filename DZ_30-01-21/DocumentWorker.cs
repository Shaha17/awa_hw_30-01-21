using System;

namespace DZ_30_01_21
{
	class DocumentWorker
	{
		public virtual void OpenDocument()
		{
			Console.WriteLine("Документ открыт");
		}
		public virtual void EditDocument()
		{
			Console.WriteLine("Редактирование документа доступно в версии Про");
		}
		public virtual void SaveDocument()
		{
			Console.WriteLine("Сохранение документа доступно в версии Про");
		}
	}
}
