using UnityEngine;
using System.Collections;

public class Video {
	public int frameNumber;
	public string fileName;
	public string folderName;
	public string imageName;
	public BallColor color;

	public Video(int _frameNumber, string _fileName, string _folderName, string _imageName, BallColor _color) {
		frameNumber = _frameNumber;
		fileName = _fileName;
		folderName = _folderName;
		imageName = _imageName;
		color = _color;
	}

	public Video(int _frameNumber, string _fileName, string _folderName) {
		frameNumber = _frameNumber;
		fileName = _fileName;
		folderName = _folderName;
		imageName = null;
	}

	public Video(string _fileName, string _folderName, string _imageName, BallColor _color) {
		fileName = _fileName;
		folderName = _folderName;
		imageName = _imageName;
		color = _color;

	}

	//used in VideoManager during setReviewWord()
	public Video (string _fileName, string _folderName) {
		fileName = _fileName;
		folderName = _folderName;
		imageName = null;
	}

	// Use this for initialization
	void Start () {

	}

}
