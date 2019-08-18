using System;
using System.IO.Ports;
using System.Threading;
using Agilent.AgXSAn.Interop;
using Agilent.Ag532xx.Interop;
using InstrumentDrivers;
using RohdeSchwarz.RsScope;

namespace Radik
{
    #region Источник питания HMP4040
    public class HMP4040
    {
        SerialPort serialPort;
        /// <summary>
        /// Метод подключается к устройству, через выбранный COM порт.
        /// </summary>
        /// <param name="port">название COM порта</param>
        public void connect(string port)
        {
            serialPort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
            serialPort.Handshake = Handshake.RequestToSend;
        }

        /// <summary>
        /// Метод устанавливает напряжение и ток на выбранном канале.
        /// </summary>
        /// <param name="channel">Номер канала</param>
        /// <param name="voltage">Напряжение</param>
        /// /// <param name="amper">Ток</param>
        public void channelConfig(int channel, string voltage, string amper)
        {
            serialPort.Open();
            serialPort.WriteLine("INST OUT" + channel);
            Thread.Sleep(100);
            serialPort.WriteLine("VOLT " + voltage);
            Thread.Sleep(100);
            serialPort.WriteLine("CURR " + amper);
            Thread.Sleep(100);
            serialPort.Close();
        }

        /// <summary>
        /// Включает или выключает выбранный канал.
        /// </summary>
        /// <param name="channel">Номер канала</param>
        /// <param name="power">Состояние канала (ON|OFF). True - ON, false - OFF</param>
        public void channelState(int channel, bool power)
        {
            serialPort.Open();
            serialPort.WriteLine("INST OUT" + channel);
            Thread.Sleep(100);
            serialPort.WriteLine("OUTP " + Convert.ToByte(power));
            Thread.Sleep(100);
            serialPort.Close();
        }

        /// <summary>
        /// Метод возвращает идентификатор устройства
        /// </summary>
        /// <returns></returns>
        public string idn()
        {
            string identifier = "";
            serialPort.Open();
            serialPort.WriteLine("*IDN?");
            Thread.Sleep(100);
            identifier = serialPort.ReadLine();
            Thread.Sleep(100);
            serialPort.Close();
            return identifier;
        }
    }
    #endregion

    #region Генератор сигналов SMA100A
    public class SMA100A
    {
        rssma signalGenerator;

        /// <summary>
        /// Метод подключается к устройству.
        /// </summary>
        /// <param name="ip">IP адрес устройства</param>
        /// <param name="IDQuery"></param>
        /// <param name="resetDevice"></param>
        public void connect(string ip, bool IDQuery, bool resetDevice)
        {
            //TCPIP::192.168.0.83::INSTR
            string con_str = "TCPIP::" + ip + "::INSTR";
            signalGenerator = new rssma(Convert.ToString(con_str), IDQuery, resetDevice);
        }

        /// <summary>
        /// Метод устанавливает частоту и мощность.
        /// </summary>
        /// <param name="Frequency">Частота</param>
        /// <param name="RFLevel">Мощность</param>
        public void RFConfig(double Frequency, double RFLevel)
        {
            signalGenerator.confRFFreq(Frequency, 0.0, false, 0.0);
            signalGenerator.confRFLevel(RFLevel, 0.0, 30.0, false, 0.0, rssmaConstants.OutputAmodeAuto, rssmaConstants.PowerLevelRclExclude);
        }

        /// <summary>
        /// Метод включает или отключает генерацию сигнала.
        /// </summary>
        /// <param name="state">состояние</param>
        public void outputState(bool state)
        {
            signalGenerator.SetOutputState(state);
        }
    }
    #endregion

    #region Анализатор спектра N9038A
    public class N9038A
    {
        AgXSAn instrument = null;

        //Режимы анализатора спектра
        public enum Mode
        {
            sAnalyzer, // Режим: Анализатор спектра
            phaseNoise // Режим: Фазовые шумы
        }

        /// <summary>
        /// Метод изменяет режим анализатора спектра
        /// </summary>
        /// <param name="mode"></param>
        public void changeMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.sAnalyzer:
                    instrument.System.DirectIO.WriteString("INST:SEL SA");
                    break;
                case Mode.phaseNoise:
                    instrument.System.DirectIO.WriteString("INST:SEL PNOISE");
                    break;
            }
        }

        /// <summary>
        /// Метод подключается к устройству.
        /// </summary>
        /// <param name="ip">IP адрес устройства</param>
        /// <param name="idQuery"></param>
        /// <param name="resetDevice"></param>
        public void connect(string ip, bool idQuery, bool resetDevice)
        {
            instrument = new AgXSAn();
            string con_str = "TCPIP::" + ip + "::INSTR";
            instrument.Initialize(con_str, idQuery, resetDevice);

        }

        /// <summary>
        /// Метод устанавливает полосу обзора.
        /// </summary>
        /// <param name="startFrequency">Стартовая частота</param>
        /// <param name="stopFrequency">Конечная частота</param>
        public void setStartAndStopFrequency(double startFrequency, double stopFrequency)
        {
            instrument.Frequency.ConfigureStartStop(startFrequency, stopFrequency);
        }

        /// <summary>
        /// Метод выключает или выключает маркер.
        /// </summary>
        /// <param name="state">Состояние маркера(ON|OFF). True - ON, false - OFF.</param>
        public void markerState(bool state)
        {
            switch (state)
            {
                case true:
                    instrument.System.DirectIO.WriteString(":CALC:FSC:MARK1:MODE POS");
                    break;
                case false:
                    instrument.System.DirectIO.WriteString(":CALC:FSC:MARK1:MODE OFF");
                    break;
            }
        }

        /// <summary>
        /// Метод устанавливает маркер на выбранную частоту.
        /// </summary>
        /// <param name="value">Частота</param>
        public void configMarker(double value)
        {
            instrument.System.DirectIO.WriteString(":CALC:FSC:MARK1:X " + value.ToString());
        }

        /// <summary>
        /// Метод считывает амплитуду c выбранного маркера.
        /// </summary>
        /// <returns></returns>
        public double readAmplitude()
        {
            instrument.System.DirectIO.WriteString(":CALC:FSC:MARK1:Y?");
            return Convert.ToDouble(instrument.System.DirectIO.ReadString());
        }

        /// <summary>
        /// Метод отправляет SCPI-команду на устройство.
        /// </summary>
        /// <param name="command">SCPI-команда</param>
        public void sendCommand(string command)
        {
            instrument.System.DirectIO.WriteString(command);
        }

    }
    #endregion

    #region Частотомер Ag53230A

    public class Ag53230A
    {
        Ag532xx instrument = null;

        /// <summary>
        /// Метод подключается к устройству.
        /// </summary>
        /// <param name="id">IP адрес устройства </param>
        /// <param name="idQuery"></param>
        /// <param name="resetDevice"></param>
        public void connect(string ip, bool idQuery, bool resetDevice)
        {
            string con_str = "TCPIP0::" + ip + "::inst0::INSTR";
            instrument.Initialize(con_str, idQuery, resetDevice);
        }


        /// <summary>
        /// Метод считывает частоту с выбранного канала.
        /// </summary>
        /// <param name="channel">Номер канала</param>
        /// <returns></returns>
        public double readFrequency(int channel)
        {
            instrument.System.DirectIO.WriteString("MEAS:FREQ? (@" + channel + ")");
            Thread.Sleep(100);
            return Double.Parse(instrument.System.DirectIO.ReadString());
        }
    }
    #endregion

    #region Мультиметр

    public class GDM
    {
        SerialPort serialPort;

        /// <summary>
        /// Метод подключается к устройству, через выбранный COM порт.
        /// </summary>
        /// <param name="port">Имя порта</param>
        public void connect(string port)
        {
            serialPort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
            serialPort.Handshake = Handshake.XOnXOff;
        }


        /// <summary>
        /// Метод возвращает текущее значение тока.
        /// </summary>
        public double readCurrent()
        {
            serialPort.WriteLine("MEAS:CURR:DC?");
            return Double.Parse(serialPort.ReadLine());
        }

        /// <summary>
        /// Метод возвращает текущее значение напряжения.
        /// </summary>
        /// <returns></returns>
        public double readVoltage()
        {
            serialPort.WriteLine("MEAS:VOLT:DC?");
            return Double.Parse(serialPort.ReadLine());
        }

        /// <summary>
        /// Метод возвращает идентификатор устройства
        /// </summary>
        /// <returns></returns>
        public string idn()
        {
            string identifier = "";
            serialPort.Open();
            serialPort.WriteLine("*IDN?");
            Thread.Sleep(100);
            identifier = serialPort.ReadLine();
            Thread.Sleep(100);
            serialPort.Close();
            return identifier;
        }
    }
    #endregion

    #region Осциллограф RTO1024
    public class RTO1024
    {
        RsScope driver;
        /// <summary>
        /// Метод подключается к устройству.
        /// </summary>
        /// <param name="ip">IP адрес устройства</param>
        /// <param name="IDQuery"></param>
        /// <param name="resetDevice"></param>
        public void connect(string ip, bool IDQuery, bool resetDevice)
        {
            string con_str = "TCPIP::" + ip + "::INSTR";
            driver = new RsScope(con_str, IDQuery, resetDevice);
        }

        /// <summary>
        /// Базовая настройка устройства
        /// </summary>
        public void config()
        {
            driver.Measurements["M1"].GeneralSettings.Enabled = true;
            driver.Measurements["M1"].GeneralSettings.Source(WaveformParameter.Channel1Waveform1);
            driver.Measurements["M1"].GeneralSettings.Category = MeasurementCategory.Amplitude;
            driver.Measurements["M1"].GeneralSettings.LimitType = LimitType.Off;
            driver.Measurements["M1"].StatisticsAndLongTerm.StatisticsEnabled = true;
            driver.Measurements["M1"].AmplitudeTime.MainMeasurement = AmplitudeTimeMeasurementType.MeanValue;
        }

        /// <summary>
        /// Считывание значения с устройства
        /// </summary>
        public double read()
        {
            double val = driver.Measurements["M1"].Results.FetchMainMeasurement(StatisticsType.Actual);
            return val;
        }

    }
    #endregion

    #region Микросхема
    public class Microcontroller
    {
        public bool connect(string port)
        {
            /* подколючение */
            return true;
        }

        public void setFreq(double freq)
        {
            /* выходная частота */
        }

        public void setLev(double level)
        {
            /* выходная мощность */
        }
    }
    #endregion
}
