using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCDI.Service
{
   public class MessageBoxService: IMessageBoxService
    {
        public MessageBoxService()
        {
        }

        /// <summary>
        /// 顯示錯誤訊息
        /// </summary>
        /// <param name="message">錯誤訊息</param>
        public void ShowError(string message)
        {
            MessageBox.Show(message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //MessageBox.Show(new Form { TopMost = true }, message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 顯示訊息
        /// </summary>
        /// <param name="message">訊息</param>
        public void ShowInformation(string message)
        {
            MessageBox.Show(message, "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(new Form { TopMost = true }, message, "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 詢問訊息
        /// </summary>
        /// <param name="message">訊息</param>
        /// <returns></returns>
        public bool ShowQuestion(string message)
        {
            return DialogResult.Yes == MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //return DialogResult.Yes == MessageBox.Show(new Form { TopMost = true }, message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// 詢問訊息
        /// </summary>
        /// <param name="message">訊息</param>
        /// <returns></returns>
        public DialogResult ShowQuestionCancel(string message)
        {
            return MessageBox.Show(message, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //return MessageBox.Show(new Form { TopMost = true }, message, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        /// <summary>
        /// 顯示警告訊息
        /// </summary>
        /// <param name="message">警告訊息</param>
        public void ShowWarning(string message)
        {
            MessageBox.Show(message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //MessageBox.Show(new Form { TopMost = true }, message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
