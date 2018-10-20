using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callcenter.Infra.FaceAPI
{
    public class FaceApi
    {
        private static readonly FaceAttributeType[] faceAttributes = { FaceAttributeType.Emotion };

        private readonly IFaceServiceClient _faceserviceclient;

        public FaceApi(string apiKey)
        {
            _faceserviceclient = new FaceServiceClient(apiKey, "https://brazilsouth.api.cognitive.microsoft.com/face/v1.0");
        }

        public async Task<VerifyResult> Compare(Stream image1, Stream image2)
        {
            Guid faceid1;
            Guid faceid2;

            var faces = await _faceserviceclient.DetectAsync(image1, returnFaceId: true);
            if (faces.Length > 0)
                faceid1 = faces[0].FaceId;
            else
                throw new Exception("No face found in image 1.");

            var faces2 = await _faceserviceclient.DetectAsync(image2, returnFaceId: true);
            if (faces2.Length > 0)
                faceid2 = faces2[0].FaceId;
            else
                throw new Exception("No face found in image 2.");

            return await _faceserviceclient.VerifyAsync(faceid1, faceid2);
        }

        public async Task<int> DetectFace(Stream stream)
        {
            var faces = await _faceserviceclient.DetectAsync(stream, returnFaceId: true);
            return faces.Length;
        }

        public async Task<Face> DetectMood(Stream stream)
        {
            Guid faceid1;

            var faces = await _faceserviceclient.DetectAsync(stream, returnFaceId: true, returnFaceAttributes: faceAttributes);

            if (faces.Length > 0)
                faceid1 = faces[0].FaceId;
            else
                throw new Exception("No face found in image 1.");

            return faces[0];
        }
    }
}
