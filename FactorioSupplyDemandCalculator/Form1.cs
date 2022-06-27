namespace FactorioSupplyDemandCalculatorUI
{
    public partial class Form1 : Form
    {
        CalculationLogic calculationLogic;
        InputValidator inputValidator;


        public Form1()
        {
            InitializeComponent();
            calculationLogic = new CalculationLogic();
            inputValidator = new InputValidator();
        }

        private void numberOfProductionFactoriesTBox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("===================fired");
            calculationLogic.NumberOfDemandingFactories = 0;

            var text = numberOfProductionFactoriesTBox.Text;
            if (inputValidator.IsInputValid(text))
            {
                calculationLogic.NumberOfProducingFactories = double.Parse(text);
                calculationLogic.Calculate();
            }
        }

        private void numberOfDemandingFactoriesTBox_TextChanged(object sender, EventArgs e)
        {
            calculationLogic.NumberOfProducingFactories = 0;

            var text = numberOfDemandingFactoriesTBox.Text;
            if (inputValidator.IsInputValid(text))
            {
                calculationLogic.NumberOfDemandingFactories = double.Parse(text);
                calculationLogic.Calculate();
            }

        }

        private void demandRateTBox_TextChanged(object sender, EventArgs e)
        {
            var text = demandRateTBox.Text;
            if (inputValidator.IsInputValid(text))
            {
                calculationLogic.DemandRate = double.Parse(text);
                calculationLogic.Calculate();
            }
        }

        private void productionRateTBox_TextChanged(object sender, EventArgs e)
        {
            var text = productionRateTBox.Text;
            if (inputValidator.IsInputValid(text))
            {
                calculationLogic.ProductionRate = double.Parse(text);
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            ChangeLabel();
            resultsTBox.Text = calculationLogic.Calculate().ToString();
            calculationLogic.ResetValues();
            ResetTextBoxes();
        }

        private void ResetTextBoxes()
        {
            numberOfDemandingFactoriesTBox.Text = "";
            numberOfProductionFactoriesTBox.Text = "";
            productionRateTBox.Text = "";
            demandRateTBox.Text = "";
        }

        private void ChangeLabel()
        {
            var cl = calculationLogic;
            //n_demand
            if (cl.NumberOfProducingFactories > 0 
                && cl.ProductionRate > 0
                && cl.DemandRate > 0 
                && !(cl.NumberOfDemandingFactories > 0))
            {
                ValueLabelTBox.Text = "n. demand";
            }
            //n_supplu
            else if (cl.NumberOfDemandingFactories > 0
                && cl.ProductionRate > 0
                && cl.DemandRate > 0
                && !(cl.NumberOfProducingFactories > 0))
            {
                ValueLabelTBox.Text = "n. supply";
            }
            else
            {
                ValueLabelTBox.Text = "NaN";
            }
        }
    }
}