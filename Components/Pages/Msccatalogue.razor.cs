using System.Reflection;
using TyphoonTaskingTool.Components.RigForms;
using TyphoonTaskingTool.Data;
using TyphoonTaskingTool.Components.Pages.RequestPages;

namespace TyphoonTaskingTool.Components.Pages
{
    public partial class Msccatalogue
    {
        private List<CataCardItem> CataCardItems = new()
        {
            new() { title = "General Request", imagePath = "images/0_Russian-invasion-of-Ukraine.jpg", description = "Raise a General Request if you are unsure of what your requirement is.", warning = "Requests for Information", DialogComponent = typeof(Create) },
            new() { title = "Single Mission Data", imagePath = "images/image1.png", description = "Single Mission Data", warning = "This is not Multi-Mission Data", DialogComponent = typeof(DefaultDialogue) },
            new() { title = "Multi Mission Data", imagePath = "images/111_4743ww7.jpg", description = "Multi Mission Data", warning = "This is not Single Mission Data", DialogComponent = typeof(RigRequestDialogue) },
            new() { title = "Routine Mapping", imagePath = "images/image2.png", description = "Request Routine Mapping up to OS", warning = "You may only request upto OS", DialogComponent = typeof(RigRequestDialogue) },
            new() { title = "Operational Mapping", imagePath = "images/getsitelogo.png", description = "Request operational mapping up to OS", warning = "You may only request upto OS", DialogComponent = typeof(Create) },
            new() { title = "Projects Disk/Application", imagePath = "images/800px-RAF_Typhoon_Jet_is_Towed_from_its_Hangar_at_RAF_Coningsby_in_the_Snow_MOD_45152132.jpg", description = "Request for updates or information on Projects Disk", warning = "For further detail contact DBTE team", DialogComponent = typeof(RigRequestDialogue) },
            new() { title = "Rig Booking - T&E", imagePath = "images/getsitelogo.png", description = "Test and Evaluation requires CCB process to be completed", warning = "Test & Evaluation", DialogComponent = typeof(RigRequestDialogue) },
            new() { title = "Rig Booking - Fault Invest", imagePath = "images/image5.png", description = "Ensure you assign the correct priority to this request", warning = "Ground based Fault Investigation", DialogComponent = typeof(RigRequestDialogue) },
        };
    }
}