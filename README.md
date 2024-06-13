## 网易易盾
https://dun.163.com
## 接口说明

- 文件说明

```
.
├── AigcStreamCheckkV1ApiDemo.cs aigc文本流式检测接口演示
├── AigcStreamCallbackApiDemo.cs aigc文本流式检测结果获取接口演示
├── AudioSubmitApiDemo.cs 点播语音提交接口演示
├── AudioCallbackApiDemo.cs　点播语音离线结果获取接口演示
├── AudioQueryByTaskIdsDemo.cs　点播语音taskId查询接口演示
├── LiveAudioSubmitApiDemo.cs　直播语音流信息提交接口演示
└── LiveAudioCallbackApiDemo.cs 直播语音流检测结果获取接口演示
├── VideoSubmitApiDemo.cs　点播视频在线检测接口演示
├── VideoCallbackDemo.cs 点播视频离线结果获取接口演示
├── VideoDataQueryDemo.cs 点播视频截图查询接口演示
├── FileSolutionSubmitApiDemo.cs　文档解决方案提交接口演示
├── FileSolutionCallbackApiDemo.cs 文档解决方案离线结果获取接口演示
├── FileSolutionQueryApiDemo.cs 文档解决方案查询接口接口演示
├── VideoSolutionSubmitApiDemo.cs　点播音视频解决方案提交接口演示
├── VideoSolutionCallbackApiDemo.cs 点播音视频解决方案离线结果获取接口演示
├── VideoSolutionQueryApiDemo.cs 点播音视频taskId查询接口演示
├── LiveVideoSolutionSubmitApiDemo.cs　直播音视频解决方案提交接口演示
├── LiveVideoSolutionCallbackApiDemo.cs 直播音视频解决方案离线结果获取接口演示
├── CrawlerSolutionSubmitApiDemo.cs　网站检测解决方案提交接口演示
├── CrawlerSolutionCallbackApiDemo.cs 网站检测解决方案离线结果获取接口演示
├── TextCheckApiDemo.cs 文本在线检测接口演示
├── TextBatchCheckApiDemo.cs 文本批量在线检测接口演示
├── TextCallbackDemo.cs　文本离线结果获取接口演示
├── TextQueryByTaskIdsDemo.cs　文本taskId查询接口演示
├── TextSubmitApiDemo.cs　文本数据抄送接口演示
├── ImageCheckApiDemo.cs　图片在线检测接口演示
├── ImageCallbackDemo.cs 图片离线结果获取接口演示
├── ImageQueryByTaskIdsDemo.cs 图片taskId查询接口演示
├── ImageSubmitApiDemo.cs 图片数据抄送接口演示
├── LiveVideoSubmitApiDemo.cs　直播流信息提交接口演示
└── LiveVideoCallbackApiDemo.cs 直播流检测结果获取接口演示
├── LiveWallSubmitApiDemo.cs　直播电视墙信息提交接口演示
└── LiveWallCallbackApiDemo.cs 直播电视墙检测结果获取接口演示
└── LiveDataQueryDemo.cs 直播截图查询结果获取接口演示
└── KeywordSubmitApiDemo.cs 易盾敏感词添加接口演示
└── KeywordDeleteApiDemo.cs 易盾敏感词删除接口演示
└── ListSubmitApiDemo.cs 易盾名单添加接口演示
├── MediaSolutionSubmitApiDemo.cs　融媒体解决方案提交接口演示
├── MediaSolutionCallbackApiDemo.cs 融媒体解决方案离线结果获取接口演示
└── Utils.cs 一些通用的功能函数
```
接口都支持SM3加密方法，默认为MD5。如有需要，可参考ImageCheckApiDemo.cs进行指定
