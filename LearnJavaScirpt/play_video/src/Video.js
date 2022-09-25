import {useRef, forwardRef, useImperativeHandle } from 'react'
import video1 from './video/video1.mp4'

function Video (prop, ref) {
    const videoRef =useRef()
    useImperativeHandle (ref, ()=> ({
        play() {
            videoRef.current.play()
        },
        pause() {
            videoRef.current.pause()
        }
    }))

    return (
        <video
            ref={videoRef}
            src={video1}
            width={200}
            height={500}
            controls
        />
    )
}

export default forwardRef(Video)