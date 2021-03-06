﻿using System;

namespace BreadPlayer.Web.BaiduLyricsAPI.Interface
{
    public abstract class AbstractMusic
    {
        public abstract Uri GetDataSoure();

        public abstract Int32 GetDuration();

        public abstract MusicType GetMusicType();

        /**
         * 获取歌曲名
         */
        public abstract string GetTitle();

        public abstract string GetArtist();

        //    /**
        //     * 获取艺术家图片
        //     * @return   uri
        //     */
        //    public abstract string getArtPic();

        /**
         * 加载艺术家图片  上面的方法废弃
         *
         * @param loadListener
         */
        public abstract void LoadArtPic(IOnLoadListener loadListener);


        public abstract void LoadArtPic(PicSizeType picSizeType, IOnLoadListener loadListener);

        /**
         * 专辑图片高斯模糊值
         * @return
         */
        public abstract int BlurValueOfPlaying();

        /**
         * 获取时间字符串
         *
         * @return
         */
        public string GetDurationStr()
        {
            return GetDuration().ToString(@"mm\:ss");           
        }

        public bool IsOnlineMusic()
        {
            return GetMusicType() == MusicType.Online;
        }


        public enum MusicType
        {
            Local, Online
        }

        public interface IOnLoadListener
        {
            //void OnSuccessLoad(Bitmap bitmap);
        }

        /**
         * PIC 尺寸枚举
         */
        public enum PicSizeType
        {
            Small, Big, Preium, Huge
        }
    }
}
