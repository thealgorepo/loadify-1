﻿namespace loadify.Audio
{
    /// <summary>
    /// Base class for audio converters. Every converter needs to implement the Convert function for converting
    /// an audio file from one format to another
    /// </summary>
    public abstract class AudioConverter
    {
        /// <summary>
        /// The file extension of the converted file
        /// </summary>
        public string TargetFileExtension { get; set; }

        /// <param name="targetFileExtension"> The file extension of the converted file</param>
        public AudioConverter(string targetFileExtension)
        {
            TargetFileExtension = targetFileExtension;
        }

        /// <summary>
        /// Converts the specified audio file to another format
        /// </summary>
        /// <param name="filePath"> Path to the audio file being converted </param>
        /// <param name="outputFilePath"> Path where to store the converted file </param>
        public abstract void Convert(string filePath, string outputFilePath);
        public virtual void Release() { }
    }
}
