using System;

namespace DZ_30_01_21
{
	class ProDocumentWorker : DocumentWorker
	{
		public override void EditDocument()
		{
			Console.WriteLine("Документ отредактирован");
		}
		public override void SaveDocument()
		{
			Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
		}
	}
}
