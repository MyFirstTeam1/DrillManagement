using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSFramework.Common
{
    public class UCManager
    {
        Dictionary<string, UserControl> userControls = new Dictionary<string, UserControl>();
        Control userControlContainer = null;
        string currentControlKey = string.Empty;
        string defaultControlKey = string.Empty;
        UserControl currentControl = null;

        public UCManager(Control container)
        {
            if (container == null)
                throw new ArgumentNullException(" Container can not be null !");
            this.userControlContainer = container;
        }

        public UCManager(Control container, string defalutKey) :
            this(container)
        {
            this.defaultControlKey = defalutKey;
        }

        public Control UserControlContainer
        {
            get
            {
                return this.userControlContainer;
            }
        }

        public string ManagerDefaultControlKey
        {
            get
            {
                return this.defaultControlKey;
            }
            set
            {
                this.defaultControlKey = value;
            }
        }

        public string CurrentControlKey
        {
            set
            {
                currentControlKey = value;
            }
            get
            {
                return this.currentControlKey;
            }
        }

        public UserControl CurrentControl
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("CurrentControl can not be null !");

                if (value != null && currentControl != value)
                {
                    BeforeCurrentControlChanged();
                    currentControl = value;
                    AfterCurrentControlChanged();
                }
            }
            get
            {
                return currentControl;
            }
        }

      
        public void ActivateControl(string cName)
        {
            if (cName == currentControlKey)
                return;
            UserControl baseControl = null;
            if (!TryGetExistsByName(cName, ref baseControl))
                baseControl = CreateControlByName(cName);
            CurrentControl = baseControl;            
            CurrentControlKey = cName;
        }


        public void AddControlBehind(string cName)
        {
               UserControl baseControl = null;
            if (!TryGetExistsByName(cName, ref baseControl))
                baseControl = CreateControlByName(cName);
            if (currentControl != null)
                currentControl.BringToFront();
        }

        public void RemoveControl(string cName)
        {
            if (userControls.ContainsKey(cName))
            {
                userControlContainer.Controls.Remove(userControls[cName]);
                userControls[cName].Dispose();
                userControls.Remove(cName);
            }
            if (cName == CurrentControlKey)
            {
                CurrentControl = userControls[ManagerDefaultControlKey];
                CurrentControlKey = ManagerDefaultControlKey;
            }
        }
                

        public void Activate()
        {
            if (userControlContainer != null)
                userControlContainer.BringToFront();
            if (CurrentControl != null)
            {
                /* 新逻辑不明先注释掉 terry 2018.11.13
                CurrentControl.Activate();                
                //if (CurrentControlTitleChanged != null)
                //{
                //    CurrentControlTitleChanged(CurrentControl.ContentTitle);
                //}
                 */
            }
        }

        public Action<string> CurrentControlTitleChanged;

        private void BeforeCurrentControlChanged()
        {
            //不知道业务逻辑先注释掉Terry 2018.11.13
            //if (currentControl != null)
                //currentControl.InActivate();
        }

        private void AfterCurrentControlChanged()
        {
            //不知道业务逻辑先注释掉Terry 2018.11.13
            //currentControl.Activate();
            currentControl.BringToFront();
            //OnCurrentContentTitleChanged(currentControl.ContentTitle);
        }

        private void OnCurrentContentTitleChanged(string ContentTitle)
        {
            if (CurrentControlTitleChanged != null)
            {
                CurrentControlTitleChanged(ContentTitle);
            }
        }

        private UserControl CreateControlByName(string cName)
        {

            UserControl baseControl = UIControlCreater.CreateControl(cName);
            userControls.Add(cName, baseControl);
            baseControl.Dock = DockStyle.Fill;            
            userControlContainer.Controls.Add(baseControl);
            return baseControl;
        }

        public bool Exists(string cName)
        {
            return userControls.ContainsKey(cName);
        }

        private bool TryGetExistsByName(string cName, ref UserControl control)
        {
            if (userControls.ContainsKey(cName))
            {
                control = userControls[cName];
                return true;
            }
            else
                return false;
        }

        public UserControl TryGetExistsByName(string cName)
        {
            if (userControls.ContainsKey(cName))
            {
                return userControls[cName];
            }
            else
                return null;
        }
    }

}
