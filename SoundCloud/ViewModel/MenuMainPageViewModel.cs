using System.Collections.ObjectModel;
using SoundCloud.Model;

namespace SoundCloud.ViewModel
{
    public class MenuMainPageViewModel
    {
        ObservableCollection<MenuMainPage> MenuList = new ObservableCollection<MenuMainPage>();
        //Ở đây chúng ta sẽ lấy dử liệu từ database,webservice...
        //Do chúng ta không có database nên tôi sẽ tạo mỗi items cho listbox

        public ObservableCollection<MenuMainPage> GetMenu()
        {
            MenuList.Add(new MenuMainPage { name = "SoundCloud", thumbail = "/Logo/soundcloudlogo.png", description = "Listen,download music" });
            

            return MenuList;
        }
    }
}
