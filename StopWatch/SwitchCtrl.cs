using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class StopWatch
    {
        /// <summary>
        /// Start_Stopボタン押下時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Stop_Click(object sender, EventArgs e)
        {
            // Start_Stopボタンの表示が"Start"の場合
            if (Start_Stop.Text == "Start")
            {
                // Lap_Resetボタンを活性化する。
                Lap_Reset.Enabled = true;
                // 現在時刻を取得する。
                StartTime = DateTime.Now;
                // バックグラウンド操作を実行する。
                bw.RunWorkerAsync();
                // Start_Stopボタンのボタン表示を"Stop"に変える。
                Start_Stop.Text = "Stop";
                // Start_Stopボタンの色をStopの色に変更する。(青色っぽい色)
                Start_Stop.BackColor = Color.FromArgb(65, 105, 225);
                // Lap_Resetボタンのボタン表示を"Lap"に変える。
                Lap_Reset.Text = "Lap";
                // Lap_Resetボタンの色をLapの色に変更する。(黄色っぽい色)
                Lap_Reset.BackColor = Color.FromArgb(255, 255, 128);
            }
            // Start_Stopボタンの表示が"Stop"の場合
            else
            {
                // バックグラウンド操作をキャンセルする。
                bw.CancelAsync();
                // Start_Stopボタンのボタン表示を"Start"に変える。
                Start_Stop.Text = "Start";
                // Start_Stopボタンの色をStartの色に変更する。(赤色っぽい色)
                Start_Stop.BackColor = Color.FromArgb(230, 50, 0);
                // Lap_Resetボタンのボタン表示を"Reset"に変える。
                Lap_Reset.Text = "Reset";
                // Lap_Resetボタンの色をResetの色に変更する。(桃色っぽい色)
                Lap_Reset.BackColor = Color.FromArgb(255, 128, 255);
            }
        }
        /// <summary>
        /// Lap_Resetボタン押下時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lap_Reset_Click(object sender, EventArgs e)
        {
            // 時間計測中の場合
            if (bw.IsBusy)
            {
                int[] nTimes = new int[3];  // ここにラップタイムを格納する。[0]:Minutes, [1]:Seconds, [2]:MilliSeconds
                int nMinutes = 0;         // ラップタイムが何分か判定する。
                double dBuf;                 // この変数に格納してひとつ前のラップタイムとの差を計算する。
                // コンボボックスを活性化する。
                LapTimeList.Enabled = true;
                // ひとつ前のラップタイムとの差をミリセカンドで出す。
                dBuf = (ts.Minutes - PreLapTime[0]) * 1000 * 60 + (ts.Seconds - PreLapTime[1]) * 1000 + (ts.Milliseconds - PreLapTime[2]);
                // 差を秒に変換
                dBuf *= 0.001;
                // 小数点以下はミリセカンドなので、1000倍して下記コンボボックスで出力する。
                nTimes[2] = (int)((dBuf - Math.Floor(dBuf)) * 1000);
                // ミリセカンドは計算終了したので、切り捨てる。
                dBuf = Math.Floor(dBuf);
                // 60秒以上であれば○分×秒の形に直す。
                while (dBuf >= 60)
                {
                    dBuf -= 60;
                    nMinutes += 1;
                }
                nTimes[0] = nMinutes;
                nTimes[1] = (int)dBuf;
                // ラップタイムをコンボボックスに追加する。
                LapTimeList.Items.Add(string.Format("{0:D2}:{1:D2}.{2:D3}", nTimes[0], nTimes[1], nTimes[2]));
                // 次のラップタイム計算時にまた使うので、ここに格納しておく。
                PreLapTime[0] = ts.Minutes;
                PreLapTime[1] = ts.Seconds;
                PreLapTime[2] = ts.Milliseconds;
            }
            // 時間計測中でない場合
            else
            {
                // ラップタイムのコンボボックスを非活性化する。
                LapTimeList.Enabled = false;
                // Lap_Resetボタンを非活性化する。
                Lap_Reset.Enabled = false;
                // Lap_Resetボタンのボタン表示を"Lap"に変える。
                Lap_Reset.Text = "Lap";
                // Lap_Resetボタンの色をLapの色に変更する。(黄色っぽい色)
                Lap_Reset.BackColor = Color.FromArgb(255, 255, 128);
                // 時刻表示の数値をリセットする。
                Display.Text = "00:00.000";
                // StartTimeを00:00にリセットする。
                StartTimeReset.PerformClick();
                // コンボボックスに追加したアイテムを全て削除する。
                LapTimeList.Items.Clear();
                // Startボタン押下時刻と現在時刻の差を0にリセットする。
                ts = TimeSpan.Zero;
            }
        }
        /// <summary>
        /// infoボタン押下時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void InfoButton_Click(object sender, EventArgs e)
        {
            ShowInfoMsg();
        }
        /// <summary>
        /// StartTimeResetボタン押下時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartTimeReset_Click(object sender, EventArgs e)
        {
            StartMinTime.Value = 0;
            StartSecTime.Value = 0;
        }
        /// <summary>
        /// トグルスイッチ切り替え時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Tgl_Change(object sender, EventArgs e)
        {
            TglChanged();
        }
        /// </summary>
        /// キーダウンイベント
        /// ShiftKey押下でStart_Stop
        /// ControlKey押下でLap_Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopWatch_KeyDown(object sender, KeyEventArgs e)
        {
            // ShiftKey押下でStart_Stop
            if  (e.KeyCode == Keys.ShiftKey)
                Start_Stop.PerformClick();

            // ControlKey押下でLap_Reset
            else if (e.KeyCode == Keys.ControlKey)
                Lap_Reset.PerformClick();

            // 'R'押下でインフォメーション表示
            else if (e.KeyCode == Keys.R)
                StartTimeReset.PerformClick();

            // 'F1'押下でトグルスイッチを切り替える。
            else if (e.KeyCode == Keys.F1)
            {
                TglChange(TglSw);
                TglChanged();
            }

            // 'I'押下でインフォメーション表示
            else if (e.KeyCode == Keys.I)
                ShowInfoMsg();

            // Delete押下でStopWatch_Closing
            else if (e.KeyCode == Keys.Delete)
                Close();
        }
    }
}
