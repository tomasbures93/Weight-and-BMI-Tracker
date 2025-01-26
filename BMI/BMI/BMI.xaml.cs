namespace BMI;
    public partial class BMI : ContentPage
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
        public BMI()
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
            bool heightTest = double.TryParse(heightWert, out double height);
            string textOutput = "";
            int weightStatus = 0;        // 0 - underweight ; 1 - nomral; 2 - overweight; 3 - fehler
            bool inputOk = true;
            double bmi = weight / ((height / 100) * (height / 100));
            if (ageTest == false)
            {
                textOutput = "Age";
                inputOk = false;
            }
            if (weightTest == false)
            {
                textOutput = textOutput + ", Weight";
                inputOk = false;
            }
            if (heightTest == false)
            {
                inputOk = false;
                textOutput = textOutput + ", Height";
            }
            if (inputOk == false)
            {
                outputTip.Text = "Wrong input: " + textOutput;
            }
            else
            {
                weightStatus = CalculateStatus(age, bmi);
                PrintBMI(weightStatus, bmi);
                Progress.IsVisible = true;
            }
        }
        private int CalculateStatus(int age, double bmi)
        {
            int weightStatus = 0;
            if (age < 19)
            {
                weightStatus = 3;
            }
            else
            {
                if (age >= 19 && age <= 24)
                {
                    if (bmi < 19)
                        weightStatus = 0;
                    else if (bmi >= 19 && bmi <= 24)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
                else if (age >= 25 && age <= 34)
                {
                    if (bmi < 20)
                        weightStatus = 0;
                    else if (bmi >= 20 && bmi <= 25)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
                else if (age >= 35 && age <= 44)
                {
                    if (bmi < 21)
                        weightStatus = 0;
                    else if (bmi >= 21 && bmi <= 26)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
                else if (age >= 45 && age <= 54)
                {
                    if (bmi < 22)
                        weightStatus = 0;
                    else if (bmi >= 22 && bmi <= 27)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
                else if (age >= 55 && age <= 64)
                {
                    if (bmi < 23)
                        weightStatus = 0;
                    else if (bmi >= 23 && bmi <= 28)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
                else if (age >= 64)
                {
                    if (bmi < 24)
                        weightStatus = 0;
                    else if (bmi >= 24 && bmi <= 29)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
            }
            return weightStatus;
        }

        private void PrintBMI(int weightStatus, double bmi)
        {
            outputBMI.Text = $"{bmi:F2}";
            switch (weightStatus)
            {
                case 0:
                    //untergewicht
                    outputTip.Text = $"You are underweight";
                    PrintTip(weightStatus);
                    Progress.Progress = 0.30;
                    Progress.ProgressColor = Colors.Yellow;
                    break;
                case 1:
                    //normal
                    outputTip.Text = $"Your BMI is normal";
                    PrintTip(weightStatus);
                    Progress.Progress = 0.5;
                    Progress.ProgressColor = Colors.Green;
                    break;
                case 2:
                    //overweight
                    outputTip.Text = $"You are overweight";
                    PrintTip(weightStatus);
                    Progress.Progress = 0.70;
                    Progress.ProgressColor = Colors.OrangeRed;
                    break;
                default:
                    outputBMI.Text = "You are young.";
                    break;
            }
        }

        private void PrintTip(int weightStatus)
        {
            Random number = new Random();
            switch (weightStatus)
            {
                case 0:
                    //untergewicht
                    outputTip2.Text = underweight[number.Next(0, 10)];
                    break;
                case 1:
                    //normal
                    outputTip2.Text = normal[number.Next(0, 10)];
                    break;
                case 2:
                    //overweight
                    outputTip2.Text = overweight[number.Next(0, 10)];
                    break;
                default:
                    break;
            }
        }
    }

