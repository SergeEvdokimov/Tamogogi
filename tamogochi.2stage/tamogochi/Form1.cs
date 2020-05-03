using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamogochi
{
    public partial class Form1 : Form
    {
        
        public PictureBox[] queue;
        public PictureBox[] Stack;
        public Form1()
        {
            InitializeComponent();
            new Settings();
            init_game();
            game_timer.Interval = 1000 / Settings.speed;
            game_timer.Tick += UpdateScreen;
            game_timer.Start();
            queue_timer.Interval = 1000 / Settings.queue_speed;
            queue_timer.Tick += UpdateQueue;
            queue_timer.Start();
            Stack_timer.Interval = 1000 / Settings.Stack_speed;
            Stack_timer.Tick += UpdateStack;
            Stack_timer.Start();
            queue = new PictureBox[] {pbQueue1, pbQueue2, pbQueue3, pbQueue4, pbQueue5, pbQueue6};
            Stack = new PictureBox[] {pbStack1, pbStack2, pbStack3, pbStack4, pbStack5, pbStack6};
        }
        public void UpdateStack(object sender, EventArgs e)
        {
            show_stack_commands();
        }
        public void show_stack_commands()
        {
            for (int i = 0; i < Stack.Length; i++)
            {
                if (Settings.Stack_commands.Elements[i] != null)
                {
                    KeyValuePair<Actions, Image> cur_elem = (KeyValuePair<Actions, Image>)Settings.Stack_commands.Elements[i];
                    Stack[i].Image = cur_elem.Value;
                    Stack[i].SizeMode = PictureBoxSizeMode.Zoom;    
                }
                else
                {
                    Stack[i].Image = null;
                }
            }
        }
        public void Stack_action()
        {
            KeyValuePair<Actions, Image>? cur_elem = Settings.Stack_commands.Pop();
            if (cur_elem == null)
            {
                return;
            }
            KeyValuePair<Actions, Image> cur_elem_new = (KeyValuePair<Actions, Image>)cur_elem;
            switch (cur_elem_new.Key)
            {
                case Actions.Eat:
                    eating();
                    break;
                case Actions.Clear:
                    clearing();
                    break;
                case Actions.Sleep:
                    sleeping();
                    break;
                case Actions.Game:
                    happing();
                    break;
            }
        }
        public void UpdateQueue (object sender, EventArgs e)
        {
            show_commands();
        }
        public void show_commands()
        {
            for(int i = 0; i < queue.Length; i ++)
            {
                if(Settings.commands .Elements[i] != null)
                {
                    KeyValuePair<Actions, Image> cur_elem = (KeyValuePair<Actions, Image>)Settings.commands.Elements[i];
                    queue[i].Image = cur_elem.Value;
                    queue[i].SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    queue[i].Image = null;
                }
            }
        }
        public void action()
        {
            KeyValuePair<Actions, Image>? cur_elem = Settings.commands.Dqueue();
            if(cur_elem == null)
            {
                return;
            }
            KeyValuePair<Actions, Image> cur_elem_new = (KeyValuePair<Actions, Image>)cur_elem;
            switch(cur_elem_new.Key)
            {
                case Actions.Eat:
                    eating();
                    break;
                case Actions.Clear:
                    clearing();
                    break;
                case Actions.Sleep:
                    sleeping();
                    break; 
                case Actions.Game :
                    happing();
                    break;
            }
            set_scales();
            Settings.is_game_over = is_die();
        }
        private void init_scale(Label lbl_cur, Label lbl_max, scale scale)
        {
            lbl_cur.Text = scale.Cur.ToString();
            lbl_max.Text = scale.Max.ToString();
        }
        private void init_game()
        {
            new Settings();
            init_scale(lblEatCur, lblEatMax, Settings.eat);
            init_scale(lblSleepCur, lblSleepMax, Settings.sleep);
            init_scale(lblHappyCur, lblHappyMax, Settings.happy);
            init_scale(lblClearCur, lblClearMax, Settings.clear);
            init_scale(lblHPCur, lblHPMax, Settings.HP);
            lblGameOver.Visible = false;
        }
        private scale add_value(int add_value, scale scale)
        {
            scale.Cur += add_value;
            if(scale.Cur > scale.Max)
            {
                scale.Cur = scale.Max;
            }
            return scale;
        }
        private scale dif_value (int dif_value, scale scale)
        {
            scale.Cur -= dif_value;
            if (scale.Cur < 0)
            {
                scale.Cur = 0;
            }
            return scale;
        }
        private bool is_die()
        {
            int cur_life = (int)(0.25 * Settings.eat.Cur +
                0.25 * Settings.sleep.Cur +
                0.25 * Settings.clear.Cur +
                0.25 * Settings.happy.Cur);
            Settings.HP.Cur = cur_life;
            if(Settings.HP.Cur == 0|| Settings.clear.Cur == 0|| Settings.happy.Cur == 0|| Settings.sleep.Cur == 0|| Settings.eat.Cur == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void set_scales()
        {
            lblClearCur.Text = Settings.clear.Cur.ToString();
            lblEatCur.Text = Settings.eat.Cur.ToString();
            lblHappyCur.Text = Settings.happy.Cur.ToString();
            lblHPCur.Text = Settings.HP.Cur.ToString();
            lblSleepCur.Text = Settings.sleep.Cur.ToString();
        }
        private void eating()
        {
            Settings.eat = add_value(Settings.add, Settings.eat);
            Settings.clear = dif_value(Settings.dif, Settings.clear);
            Settings.sleep = dif_value(Settings.dif, Settings.sleep);
        }
        private void sleeping()
        {
            Settings.sleep = add_value(Settings.add, Settings.sleep);
            Settings.clear = dif_value(Settings.dif, Settings.clear);
            Settings.eat = dif_value(Settings.dif, Settings.eat);
        }
        private void clearing()
        {
            Settings.sleep = dif_value(Settings.dif, Settings.sleep);
            Settings.eat = dif_value(Settings.dif, Settings.eat);
            Settings.clear = add_value(Settings.add, Settings.clear);
        }
        private void happing()
        {
            Settings.sleep = dif_value(Settings.dif, Settings.sleep);
            Settings.eat = dif_value(Settings.dif, Settings.eat);
            Settings.happy = add_value(Settings.add, Settings.eat); 
        }
        private void game_over_actions()
        {
            lblGameOver.Image = Properties.Resources.die;
            lblGameOver.Visible = true;
            btnClear.Enabled = false;
            btnEat.Enabled = false;
            btnHappy.Enabled = false;
            btnSleep.Enabled = false;
            btnAction.Enabled = false;
            btnStackActions.Enabled = false;
        }
        
        private void btnEat_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cur_value = random.Next(0, 2);
            if (cur_value == 0)
            {
                Settings.commands.Enqueue( new KeyValuePair<Actions, Image>(Actions.Eat, Properties.Resources.btn_bg_food));
            }
            else
            {
                Settings.Stack_commands.Push(new KeyValuePair<Actions, Image>(Actions.Eat, Properties.Resources.btn_bg_food));
            }
            eating();
            set_scales();     
            Settings.is_game_over = is_die(); 
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cur_value = random.Next(0, 2);
            if (cur_value == 0)
            {
                Settings.commands.Enqueue(new KeyValuePair<Actions, Image>(Actions.Game, Properties.Resources.btn_bg_play));
            }
            else
            {
                Settings.Stack_commands.Push(new KeyValuePair<Actions, Image>(Actions.Game, Properties.Resources.btn_bg_play));
            }
            happing();
            set_scales();
            Settings.is_game_over = is_die();     
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cur_value = random.Next(0, 2);
            if (cur_value == 0)
            {
                Settings.commands.Enqueue(new KeyValuePair<Actions, Image>(Actions.Sleep, Properties.Resources.btn_bg_sleep));
            }
            else
            {
                Settings.Stack_commands.Push(new KeyValuePair<Actions, Image>(Actions.Sleep, Properties.Resources.btn_bg_sleep));
            }
            sleeping();
            set_scales();
            Settings.is_game_over = is_die();            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cur_value = random.Next(0, 2);
            if (cur_value == 0)
            {
                Settings.commands.Enqueue(new KeyValuePair<Actions, Image>(Actions.Clear, Properties.Resources.btn_bg_clear));
            }
            else
            {
                Settings.Stack_commands.Push(new KeyValuePair<Actions, Image>(Actions.Clear, Properties.Resources.btn_bg_clear));
            }
            clearing();
            set_scales();
            Settings.is_game_over = is_die();           
        }
        private void generate_action(Random random)
        {
            List<Action> actions = new List<Action>() { dec_clear, dec_eat, dec_happy, dec_sleep};
            int index = random.Next(0, actions.Count);
            actions[index]();
        }
        private void dec_eat()
        {
            Settings.eat.Cur -= Settings.default_dif;
            set_scales();
            Settings.is_game_over = is_die();
        }
        private void dec_clear()
        {
            Settings.clear.Cur -= Settings.default_dif;
            set_scales();
            Settings.is_game_over = is_die();
        }
        private void dec_sleep()
        {
            Settings.sleep.Cur -= Settings.default_dif;
            set_scales();
            Settings.is_game_over = is_die();
        }
        private void dec_happy()
        {
            Settings.happy.Cur -= Settings.default_dif;
            set_scales();
            Settings.is_game_over = is_die();
        }
        private void UpdateScreen(object sender, EventArgs e)
        {
            Random random = new Random();
            if (Settings.is_game_over)
            {
                game_over_actions();
            }
            else
            {
                int is_action = random.Next(0,2);
                if(is_action == 1)
                {
                    generate_action(random);
                }
            }
        }

        private void btnStackActions_Click(object sender, EventArgs e)
        {
            Stack_action();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            action();
        }
    }
}
