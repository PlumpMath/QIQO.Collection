﻿using NLog;
using System;
using System.Runtime.CompilerServices;
using System.IO;

namespace QIQO.Core.Logging
{
    public class Log
    {
        private static NLog.Logger GetInnerLogger(string sourceFilePath)
        {
            var logger = sourceFilePath == null ? LogManager.GetCurrentClassLogger() : LogManager.GetLogger(Path.GetFileName(sourceFilePath));
            return logger;
        }

        public static void Info(string message, [CallerFilePath] string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Info(message);
        }

        public static void Info(string message, Exception exc, [CallerFilePath]string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Info(message, exc, null);
        }

        public static void Debug(string message, [CallerFilePath]string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Debug(message);
        }

        public static void Debug(string message, Exception exc, [CallerFilePath]string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Debug(message, exc, null);
        }

        public static void Warn(string message, [CallerFilePath]string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Warn(message);
        }

        public static void Warn(string message, Exception exc, [CallerFilePath]string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Warn(message, exc, null);
        }

        public static void Error(string message, [CallerFilePath]string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Error(message);
        }

        public static void Error(string message, Exception exc, [CallerFilePath]string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Error(message, exc, null);
        }

        public static void Fatal(string message, [CallerFilePath]string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Fatal(message);
        }

        public static void Fatal(string message, Exception exc, [CallerFilePath]string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Fatal(message, exc, null);
        }

        public static void Trace(string message, [CallerFilePath]string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Trace(message);
        }

        public static void Trace(string message, Exception exc, [CallerFilePath]string sourceFilePath = null)
        {
            GetInnerLogger(sourceFilePath).Trace(message, exc, null);
        }
    }

}
