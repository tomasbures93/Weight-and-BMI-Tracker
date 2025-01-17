namespace BMI
{
    public partial class MainPage : ContentPage
    {
        string[] underweight = {"Fuel your body with nutritious meals to gain strength and energy.",
                                "Healthy weight gain starts with small, consistent steps each day.",
                                "Add calorie-dense, nutrient-rich foods like nuts, avocados, and dairy to your meals.",
                                "Your health matters—focus on building a balanced and sustainable diet.",
                                "Strength training can help you build muscle and gain weight healthily.",
                                "Celebrate every healthy choice you make towards your weight gain journey.",
                                "Drink smoothies packed with fruits, protein, and healthy fats to add calories.",
                                "Consistency in eating balanced meals will bring lasting results.",
                                "Be patient with yourself; healthy weight gain takes time and care.",
                                "Listen to your body and nourish it with foods it truly needs."};
        string[] normal = { "Keep up the great work—balance and moderation are your keys to success!",
                            "Stay active and maintain your healthy habits to enjoy lifelong vitality.",
                            "Celebrate your health today by making mindful food choices.",
                            "Consistency in your habits ensures lasting health and happiness.",
                            "Your commitment to balance inspires others—keep thriving!",
                            "Hydrate, move, and rest well to sustain your healthy lifestyle.",
                            "Stay curious about nutrition to keep growing your health knowledge.",
                            "A healthy body and mind are your most valuable assets—keep nurturing them.",
                            "You’ve built strong habits—continue to invest in yourself.",
                            "Reward yourself with self-care for maintaining your health journey."};
        string[] overweight = { "Small, consistent changes lead to big, lasting results—start today.",
                                "Prioritize your health by adding more movement and nutritious foods to your day.",
                                "Focus on progress, not perfection, and celebrate every healthy step forward.",
                                "Find joy in healthy activities that make you feel strong and energized.",
                                "Start with smaller portions and mindful eating to build better habits.",
                                "Replace sugary drinks with water to make a big impact on your health.",
                                "Choose movement you enjoy, like walking or dancing—it all counts!",
                                "Believe in yourself—you’re capable of achieving a healthier, happier you.",
                                "Cooking at home can help you control portions and make healthier choices.",
                                "Take it one day at a time; every small change makes a difference."};
        string[] obese = {  "Your journey to better health starts with one small, positive change today.",
                            "Focus on feeling better, one step at a time—your health is worth it.",
                            "Walking for 10 minutes a day is a great first step towards fitness.",
                            "Celebrate every effort—you’re taking control of your health and future.",
                            "Your strength and determination can transform your health and life."};
        public MainPage()
        {
            InitializeComponent();
        }

        private void BerechneBMI(object sender, EventArgs e)
        {
            string ageWert = ageInput.Text;
            bool ageTest = int.TryParse(ageWert, out int age);
            string weightWert = weightInput.Text;
            bool weightTest = double.TryParse(weightWert, out double weight);
            string heightWert = heightInput.Text;
            bool heightTest = int.TryParse (heightWert, out int height);
            string text = "";
            int hinweis = 0;        // 0 - underweight ; 1 - nomral; 2 - overweight; 3 - fehler
            bool eingabeOK = true;
            double bmi = weight / (height * height);
            if (ageTest == false) {
                text = "Age: Insert only numbers.\n";
                eingabeOK = false;
            } 
            if (weightTest == false)
            {
                text = text + "Weight: Insert only numbers.\n";
                eingabeOK = false;
            } 
            if (heightTest == false)
            {
                eingabeOK = false;
                text = text + "Height: Insert only numbers";
            }
            if (eingabeOK == true)
            {
                outputBMI.Text = text;
            } 
            else
            {
                // When input OK ist
                if (age < 19) {
                    hinweis = 3;
                } 
                else
                {
                    if(age >= 19 && age <= 24)
                    {
                        if (bmi < 19)
                            hinweis = 0;
                        else if (bmi >= 19 && bmi <= 24)
                            hinweis = 1;
                        else
                            hinweis = 2;                     
                    }
                    else if(age >= 25 && age <= 34)
                    {
                        if (bmi < 20)
                            hinweis = 0;
                        else if (bmi >= 20 && bmi <= 25)
                            hinweis = 1;
                        else
                            hinweis = 2;
                    }
                    else if(age >= 35 && age <= 44)
                    {
                        if (bmi < 21)
                            hinweis = 0;
                        else if (bmi >= 21 && bmi <= 26)
                            hinweis = 1;
                        else
                            hinweis = 2;
                    } 
                    else if(age >= 45 && age <= 54)
                    {
                        if (bmi < 22)
                            hinweis = 0;
                        else if (bmi >= 22 && bmi <= 27)
                            hinweis = 1;
                        else
                            hinweis = 2;
                    }
                    else if(age >= 55 && age <= 64)
                    {
                        if (bmi < 23)
                            hinweis = 0;
                        else if (bmi >= 23 && bmi <= 28)
                            hinweis = 1;
                        else
                            hinweis = 2;
                    }
                    else if(age >= 64)
                    {
                        if (bmi < 24)
                            hinweis = 0;
                        else if (bmi >= 24 && bmi <= 29)
                            hinweis = 1;
                        else
                            hinweis = 2;
                    }
                }
                switch (hinweis)
                {
                    case 0:
                        //untergewicht
                        break;
                    case 1:
                        //normal
                        break;
                    case 2:
                        //overweight
                        break;
                    default:
                        outputBMI.Text =    "You are young.\nBMI is interpreted differently because children and teens are still growing.\n" +
                                            "Instead of fixed categories like for adults, BMI is assessed using percentiles based on age and sex.";
                        break;
                }
            }
        }
    }

}
