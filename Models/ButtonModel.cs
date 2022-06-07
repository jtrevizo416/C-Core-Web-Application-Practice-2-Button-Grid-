namespace ButtonGrid.Models
{
    public class ButtonModel
    {
        public int id;
        public int buttonState;
            

        public ButtonModel(int ID, int bState)
        {
            id = ID;
            buttonState = bState;
        }

        public int ID { get { return id; } set { id = value; } }
        public int ButtonState { get { return buttonState; } set { buttonState = value; } }

    }
}
