using Cirrious.MvvmCross.ViewModels;

namespace XamMvvmCrossMarvelDemo.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		// TODO: 3. Heredar de ViewModelBase. Crear constructor inyectando el servicio de la API de Marvel
		// TODO: 5. Crear propiedades MvvmCross: SearchText, CharacterList, SearchByNameCommand, CharacterSelectionCommand


		// TODO: 6. Explicar la funcción LoadData

//		#region LoadData
//
//		private async Task LoadData (string filter = null, int limit = 0, int offset = 0)
//		{
//			IsBusy = true;
//
//			var result = await _marvelService.GetCharacters (filter, limit, offset);
//
//
//			if (result != null) {
//				CharacterList = (from p in result.Results
//					select new CharacterItemViewModel () {
//						Id = p.Id,
//						Name = p.Name,
//						Thumbnail = p.Thumbnail.Path + "." + p.Thumbnail.Extension,
//						Description = p.Description
//					}).ToList ();
//			}
//
//			IsBusy = false;
//
//		}
//
//		#endregion

		// TODO: 7. Ir a la solución de Android y Revisar el FirstView.axml y el item_template.axml

		// TODO: 8. Probar a ejecutar la app
    }
}
