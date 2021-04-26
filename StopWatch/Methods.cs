using System.Windows.Forms;

namespace StopWatch
{
    public partial class StopWatch
    {
        /// <summary>
        /// ⓘボタン押下または'I'キー押下時の動作
        /// </summary>
        private void ShowInfoMsg()
        {
            MessageBox.Show(    "Start/Stop　　　　 : ボタン押下 or Shiftキー"
                       + "\n" + "Lap/Reset　　　　　: ボタン押下 or Ctrlキー"
                       + "\n" + "StartTimeReset　: ボタン押下 or 'R'キー"
                       + "\n"
                       + "\n" + "トグルスイッチ切り替え  : F1キー"
                       + "\n"
                       + "\n" + "StopWatchクローズ  : ×ボタン押下 or Deleteキー"
                              , "操作方法");
        }
        /// <summary>
        /// Tell Messaging Time
        /// 時間を知らせる。
        /// </summary>
        private void TellMsgingTime()
        {
            // 時間になったらメッセージボックスを出す。
            if ((TglSw.Checked && ts.Minutes == FinMinute.Value && ts.Seconds == FinSecond.Value && ts.Milliseconds < 20 && ts.Milliseconds > 0))
            {
                System.Media.SystemSounds.Hand.Play();
                using (NoticeMessage notice = new NoticeMessage())
                {
                    MessageBox.Show(notice, "時間です。",
                                            "このメッセージは2.5秒後に自動で終了します。",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                }
                // ここから超過カウントを始める。
                nOverMin += 1;
            }
            // 超過時間にメッセージボックスを出す。
            if ((TglSw.Checked && ts.Minutes == FinMinute.Value + nOverMin && ts.Seconds == FinSecond.Value && ts.Milliseconds < 20 && ts.Milliseconds > 0))
            {
                System.Media.SystemSounds.Hand.Play();
                using (NoticeMessage notice = new NoticeMessage())
                {
                    MessageBox.Show(notice, nOverMin.ToString() + "分超過です。",
                                            "このメッセージは2.5秒後に自動で終了します。",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                }
                nOverMin += 1;
            }
        }
        private void TglChange(TglSwitch tgl)
        {
            if (tgl.Checked == true) tgl.Checked = false;
            else if (tgl.Checked == false) tgl.Checked = true;
        }
        /// <summary>
        /// トグルスイッチ切り替え時、このメソッドを走らせる。
        /// </summary>
        private void TglChanged()
        {
            // 超過タイムリセット
            nOverMin = 0;
            // トグルスイッチがオンになった場合
            if (TglSw.Checked)
            {
                // NumericUpDownを活性化する。
                FinMinute.Enabled = true;
                FinSecond.Enabled = true;
                MessageBox.Show(  "時間になったらお知らせします。"
                                , "アラームモードに切り替えました。");
            }
            // トグルスイッチがオフになった場合
            if (!TglSw.Checked)
            {
                // NumericUpDownを非活性化する。
                FinMinute.Enabled = false;
                FinSecond.Enabled = false;
                MessageBox.Show(  "ひたすら時間計測だけします。"
                                , "通常モードに切り替えました。");
            }
        }
    }
}
