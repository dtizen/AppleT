using Euresys.Open_eVision.EasyDeepLearning;
using System.Diagnostics;
namespace DXApplication1
{
    enum EImageType
    {
        Large,
        Middle
    }
    internal class AI
    {
        private string largeImagePath = "D:/ADMS/AI_CUT_LARGE";
        private string middleImagePath = "D:/ADMS/AI_CUT_MIDDLE";
        private string originalImagePath = "D:/";

        private AI() {
            
        }
        //private static 인스턴스 객체
        private static AI _instance = null;
        //public static 의 객체반환 함수
        public static AI Instance
        {
            get
            {
                if (_instance == null) _instance = new AI();
                return _instance;
            }
        }
        public EImageType imageType;
        public EDeepLearningTool deepLearningTool;
        public EClassificationDataset largeDataset;
        public EClassificationDataset middleDataset;
        public EDataAugmentation dataAugmentation;
        public EDatasetSplit datasetSplit;
        public void ProcessLargeImage()
        {
            
        }
        public void Initialize(string date, string processId, string waferId, EImageType imageType )
        {
            this.imageType = imageType;
            deepLearningTool = EDeepLearningTool.Create(EDeepLearningToolType.EasyClassify);
            if(this.imageType == EImageType.Large)
            {
                this.LoadLargeImages(processId);
            }
            if(this.imageType == EImageType.Middle)
            {
                this.LoadMidiumImages(processId);
            }
        }
        private void LoadMidiumImages(string processId)
        {

            //Load base defect images (processed images)
            middleDataset.AddImages(middleImagePath + "/NG/BASE/BURST/*.jpg", "BURST");
            middleDataset.AddImages(middleImagePath + "/NG/BASE/ABNORMAL_COATING/*.jpg", "ABNORMAL_COATING");
            middleDataset.AddImages(middleImagePath + "/NG/BASE/DEFOCUS/*.jpg", "DEFOCUS");
            middleDataset.AddImages(middleImagePath + "/NG/BASE/DISCOLOR/*.jpg", "DISCOLOR");
            middleDataset.AddImages(middleImagePath + "/NG/BASE/EBR_SPLATTER/*.jpg", "EBR_SPLATTER");
            middleDataset.AddImages(middleImagePath + "/NG/BASE/HOTSPOT/*.jpg", "HOTSPOT");
            middleDataset.AddImages(middleImagePath + "/NG/BASE/PARTICLE/*.jpg", "PARTICLE");
            middleDataset.AddImages(middleImagePath + "/NG/BASE/RESIDUE/*.jpg", "RESIDUE");
            middleDataset.AddImages(middleImagePath + "/NG/BASE/SCRATCH/*.jpg", "SCRATCH");
            middleDataset.AddImages(middleImagePath + "/NG/BASE/SCRIBE_AREA/*.jpg", "SCRIBE_AREA");

            //Load new defect images  (processed images)
            middleDataset.AddImages(middleImagePath + "/NG/NEW/BURST/*.jpg", "BURST");
            middleDataset.AddImages(middleImagePath + "/NG/NEW/ABNORMAL_COATING/*.jpg", "ABNORMAL_COATING");
            middleDataset.AddImages(middleImagePath + "/NG/NEW/DEFOCUS/*.jpg", "DEFOCUS");
            middleDataset.AddImages(middleImagePath + "/NG/NEW/DISCOLOR/*.jpg", "DISCOLOR");
            middleDataset.AddImages(middleImagePath + "/NG/NEW/EBR_SPLATTER/*.jpg", "EBR_SPLATTER");
            middleDataset.AddImages(middleImagePath + "/NG/NEW/HOTSPOT/*.jpg", "HOTSPOT");
            middleDataset.AddImages(middleImagePath + "/NG/NEW/PARTICLE/*.jpg", "PARTICLE");
            middleDataset.AddImages(middleImagePath + "/NG/NEW/RESIDUE/*.jpg", "RESIDUE");
            middleDataset.AddImages(middleImagePath + "/NG/NEW/SCRATCH/*.jpg", "SCRATCH");
            middleDataset.AddImages(middleImagePath + "/NG/NEW/SCRIBE_AREA/*.jpg", "SCRIBE_AREA");

            //Load base OK images (processed images)
            middleDataset.AddImages(middleImagePath + $"/OK/{processId}/BASE/*.jpg", "OK");
            //Load new OK images (processed images)
            middleDataset.AddImages(middleImagePath + $"/OK/{processId}/NEW/*.jpg", "OK");
        }
        private void LoadLargeImages(string processId)
        {
            //Load base defect images (processed images)
            largeDataset.AddImages(largeImagePath + "/NG/BASE/ABNORMAL_COATING/*.jpg", "ABNORMAL_COATING");
            largeDataset.AddImages(largeImagePath + "/NG/BASE/BURST/*.jpg", "BURST");
            largeDataset.AddImages(largeImagePath + "/NG/BASE/DEFOCUS/*.jpg", "DEFOCUS");
            largeDataset.AddImages(largeImagePath + "/NG/BASE/DISCOLOR/*.jpg", "DISCOLOR");
            largeDataset.AddImages(largeImagePath + "/NG/BASE/EBR_SPLATTER/*.jpg", "EBR_SPLATTER");
            largeDataset.AddImages(largeImagePath + "/NG/BASE/HOTSPOT/*.jpg", "HOTSPOT");
            largeDataset.AddImages(largeImagePath + "/NG/BASE/PARTICLE/*.jpg", "PARTICLE");
            largeDataset.AddImages(largeImagePath + "/NG/BASE/RESIDUE/*.jpg", "RESIDUE");
            largeDataset.AddImages(largeImagePath + "/NG/BASE/SCRATCH/*.jpg", "SCRATCH");
            largeDataset.AddImages(largeImagePath + "/NG/BASE/SCRIBE_AREA/*.jpg", "SCRIBE_AREA");
            //Load new defect images  (processed images)
            largeDataset.AddImages(largeImagePath + "/NG/NEW/ABNORMAL_COATING/*.jpg", "ABNORMAL_COATING");
            largeDataset.AddImages(largeImagePath + "/NG/NEW/BURST/*.jpg", "BURST");
            largeDataset.AddImages(largeImagePath + "/NG/NEW/DEFOCUS/*.jpg", "DEFOCUS");
            largeDataset.AddImages(largeImagePath + "/NG/NEW/DISCOLOR/*.jpg", "DISCOLOR");
            largeDataset.AddImages(largeImagePath + "/NG/NEW/EBR_SPLATTER/*.jpg", "EBR_SPLATTER");
            largeDataset.AddImages(largeImagePath + "/NG/NEW/HOTSPOT/*.jpg", "HOTSPOT");
            largeDataset.AddImages(largeImagePath + "/NG/NEW/PARTICLE/*.jpg", "PARTICLE");
            largeDataset.AddImages(largeImagePath + "/NG/NEW/RESIDUE/*.jpg", "RESIDUE");
            largeDataset.AddImages(largeImagePath + "/NG/NEW/SCRATCH/*.jpg", "SCRATCH");
            largeDataset.AddImages(largeImagePath + "/NG/NEW/SCRIBE_AREA/*.jpg", "SCRIBE_AREA");
            //Load base OK images (processed images)
            largeDataset.AddImages(largeImagePath + $"/OK/{processId}/BASE/*.jpg", "OK");
            //Load new OK images (processed images)
            largeDataset.AddImages(largeImagePath + $"/OK/{processId}/NEW/*.jpg", "OK");
        }






    }
}
