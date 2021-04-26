using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class StopWatch : Form
    {
        /// <summary>
        /// 現在時刻をここに格納する。
        /// </summary>
        DateTime Now;
        /// <summary>
        /// Startボタン押下時の時刻をここに格納する。
        /// </summary>
        DateTime StartTime;
        /// <summary>
        /// Startボタン押下時刻と現在時刻の差をとり続ける処理をバックグラウンドで行う。
        /// </summary>
        BackgroundWorker bw;
        /// <summary>
        /// Startボタン押下時の時刻と現在時刻との差をここに格納する。
        /// </summary>
        TimeSpan ts;
        /// <summary>
        /// ひとつ前のラップタイムをここに格納する。
        /// </summary>
        int[] PreLapTime = new int[3];
        /// <summary>
        /// 発表時間を1分オーバーするごとにこの変数を+1する
        /// </summary>
        int nOverMin = 0;
        /// <summary>
        /// トグルスイッチクラスのインスタンス
        /// </summary>
        TglSwitch TglSw;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StopWatch()
        {
            InitializeComponent();

            // 最初はアラーム機能使わない可能性が高いので、NumericUpDownは非活性にしておく。
            FinMinute.Enabled = false;
            FinSecond.Enabled = false;
            // 起動時はコンボボックスの使用はないので非活性にしておく。
            LapTimeList.Enabled             = false;
            // 起動時はLap_Resetボタンの使用はないので非活性にしておく。
            Lap_Reset.Enabled               = false;
            // ショートカットキー使えると便利なのでオンにする。
            KeyPreview                      = true;
            // キーダウンイベントメソッドを使用する。
            KeyDown                         += StopWatch_KeyDown;
            // 機械側の処理が忙しいだろうから、バックグラウンドで時間計測を行わせるので、BWを使用する。
            bw                              = new BackgroundWorker();
            bw.DoWork                       += Bw_DoWork;
            bw.WorkerSupportsCancellation   = true;
            // フォームクローズ時イベントを使用する。
            FormClosing                     += StopWatch_Closing;
        }
        /// <summary>
        /// ここで時間計測をする。
        /// Startボタン押下時の時刻が記録されるので、
        /// そのあとはStopボタンが押されるまで常に
        /// DateTime.NowとStartボタン押下時の時間との差を表示し続ける。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            // ユーザが0以外の値をStart fromのNumericUpDownに設定した場合
            if (StartMinTime.Value != 0 || StartSecTime.Value != 0)
            {
                // Start時間を設定する。
                ts = TimeSpan.Parse("00:" + StartMinTime.Value.ToString() + ":" + StartSecTime.Value.ToString());
            }
            // Stopボタンを押下された状態から計測を再開する場合
            if (ts.Ticks != 0)
            {
                // 現在時刻を取得する。
                Now = DateTime.Now;
                // 現在時刻とStopボタン押下時の時刻との差をStartTimeに設定する。
                StartTime = Now - ts;
            }
            // Stopボタンが押下され、bw.CancelAsync()が走るまで時間を計測して値を表示し続ける。
            while (!bw.CancellationPending)
            {
                // 現在時刻を取得する。
                Now = DateTime.Now;
                // 現在時刻とStartTimeとの差をとる。
                ts = Now - StartTime;
                try
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        Display.Text = string.Format("{0:D2}:{1:D2}.{2:D3}", ts.Minutes, ts.Seconds, ts.Milliseconds);
                    });
                    // トグルスイッチがオンの場合
                    if (TglSw.Checked)
                    {
                        //メッセージを送信する時間(残り2分と終了時間のタイミング)になるとこの関数が教えてくれる。
                        TellMsgingTime();
                    }
                }
                catch (Exception ex)
                {
                    using (Form dummyForm = new Form())
                    {
                        dummyForm.TopMost = true;
                        System.Media.SystemSounds.Asterisk.Play();
                        MessageBox.Show(dummyForm, "異常検知", ex.Message, MessageBoxButtons.OK);
                        dummyForm.TopMost = false;
                    }
                }
            }
        }
        private void StopWatch_Load(object sender, EventArgs e)
        {
            // InfoButtonについての設定
            InfoButton InfoButton       = new InfoButton();
            EventHandler InfoBtnHandler = new EventHandler(InfoButton_Click);
            InfoButton.Click            += InfoBtnHandler;
            InfoButton.Location         = new Point(335, 9);
            InfoButton.Size             = new Size(27, 27);
            InfoButton.Cursor           = Cursors.Hand;
            Controls.Add(InfoButton);

            // トグルスイッチについての設定
            TglSw                 = new TglSwitch();
            EventHandler Tgl1Handler = new EventHandler(Tgl_Change);
            TglSw.Click           += Tgl1Handler;
            TglSw.Location        = new Point(10, 12);
            TglSw.Size            = new Size(40, 21);
            TglSw.Cursor          = Cursors.Hand;
            Controls.Add(TglSw);
            TglSw.Checked         = false;
        }
        /// <summary>
        /// ウィンドウクローズ時確認メッセージ出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopWatch_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show(
                    "本当に終了しますか？", "確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
